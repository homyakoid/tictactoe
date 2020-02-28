using System.Collections.Generic;
using System.Linq;
using TicTacToe.BLL.Enums;
using TicTacToe.Core.Interfaces;
using TicTacToe.Core.Models;
using TicTacToe.Core.Services;

namespace TicTacToe.Web.Models.GameSection
{
    public class GameViewModel
    {
        public GameViewModel(int gameID, string currentUser, IGameService gameService)
        {
            Locations = new Dictionary<int, CrossZeroModel>
            {
                { 0, new CrossZeroModel() },
                { 1, new CrossZeroModel() },
                { 2, new CrossZeroModel() },
                { 3, new CrossZeroModel() },
                { 4, new CrossZeroModel() },
                { 5, new CrossZeroModel() },
                { 6, new CrossZeroModel() },
                { 7, new CrossZeroModel() },
                { 8, new CrossZeroModel() }
            };
            GameID = gameID;
            Game game = gameService.GetGame(GameID);
            Player1 = game.Player1.NickName;
            Player2 = game.Player2.NickName;
            if (currentUser == Player1)
            {
                ActivePlayer = PlayerNumber.Player1;
            }
            else
            {
                ActivePlayer = PlayerNumber.Player2;
            }

            Player1Status = (BLL.Enums.PlayerStatus)game.Player1StatusID;
            Player2Status = (BLL.Enums.PlayerStatus)game.Player2StatusID;
            IsOver = game.IsOver;
            foreach (Move move in game.Moves)
            {
                if (move.PlayerID == game.Player1.ID)
                {
                    Locations[move.MovePosition].Cross = true;
                }
                else if (move.PlayerID == game.Player2.ID)
                {
                    Locations[move.MovePosition].Zero = true;
                }
            }

            if (!IsOver)
            {
                Move lastMove = game.Moves.OrderByDescending(x => x.ID).FirstOrDefault();
                if (lastMove != null)
                {
                    if (lastMove.PlayerID == game.Player1.ID)
                    {
                        Turn = PlayerNumber.Player2;
                        GameStatus = GameStatus.Player2Turn;
                    }
                    else if (lastMove.PlayerID == game.Player2.ID)
                    {
                        Turn = PlayerNumber.Player1;
                        GameStatus = GameStatus.Player1Turn;
                    }
                }
                else
                {
                    Turn = PlayerNumber.Player1;
                    GameStatus = GameStatus.Player1Turn;
                }
            }
            else
            {
                GameStatus = GameStatus.GameOver;
            }
        }
        public string Player1 { get; set; }
        public string Player2 { get; set; }
        public int GameID { get; set; }
        public BLL.Enums.PlayerStatus Player1Status { get; set; }
        public BLL.Enums.PlayerStatus Player2Status { get; set; }
        public PlayerNumber ActivePlayer { get; set; }
        public PlayerNumber Turn { get; set; }
        public GameStatus GameStatus { get; set; }
        public bool IsOver { get; set; }
        public Dictionary<int, CrossZeroModel> Locations { get; set; }
    }
}
