using Microsoft.EntityFrameworkCore.Design;
using System;
using TicTacToe.Core.Interfaces;
using TicTacToe.Core.Models;

namespace TicTacToe.DAL
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly TTTContext context;
        private GenericRepository<User> userRepository;
        private GenericRepository<Game> gameRepository;
        private GenericRepository<Move> moveRepository;
        private GenericRepository<GameResult> gameResultRepository;
        private GenericRepository<Connection> connectionRepository;

        public UnitOfWork(TTTContext context)
        {
            this.context = context;
        }

        public IGenericRepository<User> UserRepository
        {
            get
            {

                if (userRepository == null)
                {
                    userRepository = new GenericRepository<User>(context);
                }

                return userRepository;
            }
        }

        public IGenericRepository<Game> GameRepository
        {
            get
            {

                if (gameRepository == null)
                {
                    gameRepository = new GenericRepository<Game>(context);
                }

                return gameRepository;
            }
        }

        public IGenericRepository<Move> MoveRepository
        {
            get
            {

                if (moveRepository == null)
                {
                    moveRepository = new GenericRepository<Move>(context);
                }

                return moveRepository;
            }
        }

        public IGenericRepository<GameResult> GameResultRepository
        {
            get
            {

                if (gameResultRepository == null)
                {
                    gameResultRepository = new GenericRepository<GameResult>(context);
                }

                return gameResultRepository;
            }
        }

        public IGenericRepository<Connection> ConnectionRepository
        {
            get
            {

                if (connectionRepository == null)
                {
                    connectionRepository = new GenericRepository<Connection>(context);
                }

                return connectionRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
