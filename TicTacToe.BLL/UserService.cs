using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using TicTacToe.Core.Interfaces;
using TicTacToe.Core.Models;
using TicTacToe.Core.Services;

namespace TicTacToe.BLL
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void AddConnection(int userID, string connectionID)
        {
            unitOfWork.ConnectionRepository.Insert(new Connection() { UserID = userID, ConnectionID = connectionID });
            unitOfWork.Save();
        }

        public User AddNewUser(string nickName, string password)
        {
            var user = new User
            {
                NickName = nickName,
                Password = password,
                IsOnline = true
            };
            unitOfWork.UserRepository.Insert(user);
            unitOfWork.Save();

            return user;
        }

        public IList<User> GetActiveUsersList(string nickName)
        {
            return unitOfWork.UserRepository.Get(x => x.IsOnline && !x.IsPlaying && x.NickName != nickName).ToList();
        }

        public IList<Connection> GetConnections(int userID)
        {
            return unitOfWork.ConnectionRepository.Get(x => x.UserID == userID).ToList();
        }

        public User GetUserByNickName(string nickName)
        {
            return unitOfWork.UserRepository.Get(x => x.NickName == nickName).FirstOrDefault();
        }

        public void RemoveConnection(Connection connection)
        {
            unitOfWork.ConnectionRepository.Delete(connection);
            unitOfWork.Save();
        }
        public void RemoveConnections(IList<Connection> connections)
        {
            foreach (var connection in connections)
            {
                unitOfWork.ConnectionRepository.Delete(connection);
            }

            unitOfWork.Save();
        }

        public void SetUserOnline(User user, bool isOnline)
        {
            user.IsOnline = isOnline;
            unitOfWork.Save();
        }
    }
}
