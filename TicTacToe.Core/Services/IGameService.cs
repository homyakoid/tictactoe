using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.Core.Models;

namespace TicTacToe.Core.Services
{
    public interface IGameService
    {
        Game GetGame(int gameID);
        Game CreateNewGame(string player1, string player2);
        Game GetLastGame(int userID);
        int? GetActiveGame(string currentUserName);
        void AddNewMove(int movePossition, int gameID, int playerID);
        void SetGameIsOver(Game game, int playerID);
        string CloseGame(int gameID, string currentPlayer);
        void GameInvitationAccepted(int gameID);
        void GameInvitationRejected(int gameID);
        string OpponentLost(int userID);
        void CurrentUserBack(int userID);
        string GetOpponent(int userID);
    }
}
