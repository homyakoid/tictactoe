using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.Core.Models;

namespace TicTacToe.Core.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<User> UserRepository { get; }
        IGenericRepository<Game> GameRepository { get; }
        IGenericRepository<Move> MoveRepository { get; }
        IGenericRepository<GameResult> GameResultRepository { get; }
        IGenericRepository<Connection> ConnectionRepository { get; }

        void Save();
    }
}
