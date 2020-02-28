using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.Core.Models;

namespace TicTacToe.Core.Services
{
    public interface IUserService
    {
        User AddNewUser(string nickName, string password);
        User GetUserByNickName(string nickName);
        void SetUserOnline(User user, bool isOnline);
        IList<User> GetActiveUsersList(string nickName);
        void AddConnection(int userID, string connectionID);
        IList<Connection> GetConnections(int userID);
        void RemoveConnection(Connection connection);
        void RemoveConnections(IList<Connection> connections);
    }
}
