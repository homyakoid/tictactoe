using System.Linq;
using TicTacToe.Core.Interfaces;
using TicTacToe.Core.Models;
using TicTacToe.Core.Services;

namespace TicTacToe.BLL
{
    public class GameService : IGameService
    {
        private readonly IUnitOfWork unitOfWork;

        public GameService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void AddNewMove(int movePossition, int gameID, int playerID)
        {
            var move = new Move()
            {
                GameID = gameID,
                PlayerID = playerID,
                MovePosition = movePossition
            };

            unitOfWork.MoveRepository.Insert(move);
            unitOfWork.Save();
        }

        public string CloseGame(int gameID, string currentPlayer)
        {
            Game game = GetGame(gameID);
            bool isPlayer1 = currentPlayer == game.Player1.NickName;

            game.IsOver = true;
            if (isPlayer1)
            {
                game.Player1.IsPlaying = false;
                game.Player1StatusID = (int)Enums.PlayerStatus.Leave;
            }
            else
            {
                game.Player2.IsPlaying = false;
                game.Player2StatusID = (int)Enums.PlayerStatus.Leave;
            }

            unitOfWork.Save();
            var opponent = isPlayer1 ? game.Player2.NickName : game.Player1.NickName;

            return opponent;
        }

        public Game CreateNewGame(string player1, string player2)
        {
            User player1Model = unitOfWork.UserRepository.Get(x => x.NickName == player1).First();
            player1Model.IsPlaying = true;
            User player2Model = unitOfWork.UserRepository.Get(x => x.NickName == player2).First();
            var newGame = new Game()
            {
                Player1ID = player1Model.ID,
                Player2ID = player2Model.ID,
                Player1StatusID = (int)Enums.PlayerStatus.Online,
                Player2StatusID = (int)Enums.PlayerStatus.Pending
            };
            unitOfWork.GameRepository.Insert(newGame);
            unitOfWork.Save();

            return newGame;
        }

        public void GameInvitationAccepted(int gameID)
        {
            Game game = GetGame(gameID);
            game.Player2StatusID = (int)Enums.PlayerStatus.Online;
            game.Player2.IsPlaying = true;
            unitOfWork.Save();
        }

        public void GameInvitationRejected(int gameID)
        {
            Game game = GetGame(gameID);
            game.Player2StatusID = (int)BLL.Enums.PlayerStatus.Leave;
            game.IsOver = true;
            unitOfWork.Save();
        }

        public int? GetActiveGame(string currentUserName)
        {
            User currentUser = unitOfWork.UserRepository.Get(x => x.NickName == currentUserName).First();
            if (currentUser.IsPlaying)
            {
                Game lastGame = GetLastGame(currentUser.ID);
                return lastGame.ID;
            }

            return null;
        }

        public Game GetGame(int gameID)
        {
            return unitOfWork.GameRepository.Get(x => x.ID == gameID, null, x => x.Player1, x => x.Player2, x => x.Moves).First();
        }

        public Game GetLastGame(int userID)
        {
            return unitOfWork.GameRepository.Get(x => x.Player1ID == userID || x.Player2ID == userID, x => x.OrderByDescending(y => y.ID), x => x.Player1, x => x.Player2).First();
        }

        public string GetOpponent(int userID)
        {
            string opponent;
            Game lastGame = GetLastGame(userID);
            if (lastGame.Player1ID == userID)
            {
                opponent = lastGame.Player2.NickName;
            }
            else
            {
                opponent = lastGame.Player1.NickName;
            }

            return opponent;
        }

        public void CurrentUserBack(int userID)
        {
            Game lastGame = GetLastGame(userID);
            if (lastGame.Player1ID == userID)
            {
                lastGame.Player1StatusID = (int)Enums.PlayerStatus.Online;
            }
            else
            {
                lastGame.Player2StatusID = (int)Enums.PlayerStatus.Online;
            }

            unitOfWork.Save();
        }

        public string OpponentLost(int userID)
        {
            string opponent;
            Game lastGame = GetLastGame(userID);
            if (lastGame.Player1ID == userID)
            {
                lastGame.Player1StatusID = (int)BLL.Enums.PlayerStatus.Pending;
                opponent = lastGame.Player2.NickName;
            }
            else
            {
                lastGame.Player2StatusID = (int)BLL.Enums.PlayerStatus.Pending;
                opponent = lastGame.Player1.NickName;
            }

            unitOfWork.Save();

            return opponent;
        }

        public void SetGameIsOver(Game game, int playerID)
        {
            game.IsOver = true;
            unitOfWork.GameResultRepository.Insert(new GameResult() { GameID = game.ID, PlayerID = playerID });
            unitOfWork.Save();
        }
    }
}
