using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.Core.Models;
using TicTacToe.Core.Services;
using TicTacToe.Web.Helpers;

namespace TicTacToe.Web.Hubs
{
    [Authorize]
    public class GameHub : Hub
    {
        private readonly IGameService gameService;
        private readonly IUserService userService;

        public GameHub(IGameService gameService, IUserService userService)
        {
            this.gameService = gameService;
            this.userService = userService;
        }

        public async Task InvitationAccepted(string player1, int gameId)
        {
            gameService.GameInvitationAccepted(gameId);

            await Clients.Users(player1, Context.UserIdentifier).SendAsync("InvitationAccepted");
        }
        public async Task InvitationRejected(string player1, int gameId)
        {
            gameService.GameInvitationRejected(gameId);

            await Clients.Users(player1).SendAsync("InvitationRejected");
            await Clients.Others.SendAsync("AddPlayer", Context.UserIdentifier);
        }

        public async Task InvitePlayer(string player2, int gameId)
        {
            _ = Clients.User(player2).SendAsync("InvitationSent", Context.UserIdentifier, gameId);
            await Clients.Others.SendAsync("RemovePlayer", Context.UserIdentifier);
            await Clients.Others.SendAsync("RemovePlayer", player2);
        }

        public async Task RemovePlayer()
        {
            await Clients.Others.SendAsync("RemovePlayer", Context.UserIdentifier);
        }

        public async Task AddPlayer()
        {
            await Clients.Others.SendAsync("AddPlayer", Context.UserIdentifier);
        }

        public async Task MoveDone(int gameId, int movePossition)
        {
            string currentPlayer = Context.UserIdentifier;
            Game game = gameService.GetGame(gameId);
            bool isPlayer1 = currentPlayer == game.Player1.NickName;
            string opponent = isPlayer1 ? game.Player2.NickName : game.Player1.NickName;
            int currentPlayerID = isPlayer1 ? game.Player1ID.Value : game.Player2ID.Value;

            gameService.AddNewMove(movePossition, gameId, currentPlayerID);
            await Clients.User(opponent).SendAsync("MoveDone", movePossition);

            var currentPlayerMoves = game.Moves.Where(x => x.PlayerID == currentPlayerID).Select(x => x.MovePosition).ToList();
            var winCombinations = new WinCombinations();
            IList<int> winCombination = winCombinations.GetWinCombitation(currentPlayerMoves);
            if (winCombination != null)
            {
                gameService.SetGameIsOver(game, currentPlayerID);
                await Clients.Users(currentPlayer, opponent).SendAsync("GameIsOver", winCombination, isPlayer1 ? BLL.Enums.PlayerNumber.Player1.ToString() : BLL.Enums.PlayerNumber.Player2.ToString());
            }
            else
            {
                if (game.Moves.Count == 9)
                {
                    await Clients.Users(currentPlayer, opponent).SendAsync("GameIsOver");
                }
            }
        }

        public async Task CloseGame(int gameId)
        {
            string opponent = gameService.CloseGame(gameId, Context.UserIdentifier);

            await Clients.User(opponent).SendAsync("CloseGame");
            await Clients.Others.SendAsync("AddPlayer", Context.UserIdentifier);
        }

        public override async Task OnConnectedAsync()
        {
            User currentUser = userService.GetUserByNickName(Context.UserIdentifier);
            if (currentUser == null)
            {
                throw new ApplicationException(string.Format("User with nickname {0} was not found", Context.UserIdentifier));
            }

            IList<Connection> connections = userService.GetConnections(currentUser.ID);
            if (connections.Count > 0)
            {
                var connectionIDs = connections.Select(x => x.ConnectionID).ToList();
                userService.RemoveConnections(connections);

                await Clients.Clients(connectionIDs).SendAsync("Logoff");
            }

            userService.SetUserOnline(currentUser, true);
            userService.AddConnection(currentUser.ID, Context.ConnectionId);

            if (currentUser.IsPlaying)
            {
                string opponent = gameService.GetOpponent(currentUser.ID);
                gameService.CurrentUserBack(currentUser.ID);
                await Clients.User(opponent).SendAsync("OpponentBack");
                await Clients.User(Context.UserIdentifier).SendAsync("ActiveUserBack");
            }
            else
            {
                await Clients.Others.SendAsync("AddPlayer", Context.UserIdentifier);
            }
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            User currentUser = userService.GetUserByNickName(Context.UserIdentifier);
            if (currentUser == null)
            {
                throw new ApplicationException(string.Format("User with nickname {0} was not found", Context.UserIdentifier));
            }


            IList<Connection> connections = userService.GetConnections(currentUser.ID);
            Connection currentConnection = connections.Where(x => x.ConnectionID == Context.ConnectionId).FirstOrDefault();
            if (currentConnection != null)
            {
                userService.RemoveConnection(currentConnection);
                userService.SetUserOnline(currentUser, false);
                await Clients.Others.SendAsync("RemovePlayer", Context.UserIdentifier);

                if (currentUser.IsPlaying)
                {
                    string opponent = gameService.OpponentLost(currentUser.ID);
                    await Clients.User(opponent).SendAsync("OpponentLost");
                }
            }
        }
    }
}
