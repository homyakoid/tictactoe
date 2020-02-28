using Microsoft.EntityFrameworkCore;
using TicTacToe.Core.Models;

namespace TicTacToe.DAL
{
    public class TTTContext : DbContext
    {
        public TTTContext(DbContextOptions<TTTContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Move> Moves { get; set; }
        public DbSet<GameResult> GameResults { get; set; }
        public DbSet<PlayerStatus> PlayerStatuses { get; set; }
        public DbSet<Connection> Connections { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(o => o.ID);
            modelBuilder.Entity<Game>().HasKey(o => o.ID);
            modelBuilder.Entity<Move>().HasKey(o => o.ID);
            modelBuilder.Entity<GameResult>().HasKey(o => o.ID);
            modelBuilder.Entity<PlayerStatus>().HasKey(o => o.ID);
            modelBuilder.Entity<Connection>().HasKey(o => o.ID);

            modelBuilder.Entity<PlayerStatus>().HasData(
                new PlayerStatus { ID = 1, Status = "Pending" },
                new PlayerStatus { ID = 2, Status = "Online" },
                new PlayerStatus { ID = 3, Status = "Leave" });

            modelBuilder.Entity<User>().HasAlternateKey(a => a.NickName);

            modelBuilder.Entity<Game>()
                .HasOne(p => p.Player1)
                .WithMany(b => b.Player1Games)
                .HasForeignKey(p => p.Player1ID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Game>()
                .HasOne(p => p.Player2)
                .WithMany(b => b.Player2Games)
                .HasForeignKey(p => p.Player2ID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Move>()
                .HasOne(p => p.Player)
                .WithMany(b => b.Moves)
                .HasForeignKey(p => p.PlayerID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Move>()
                .HasOne(p => p.Game)
                .WithMany(b => b.Moves)
                .HasForeignKey(p => p.GameID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<GameResult>()
                .HasOne(p => p.Player)
                .WithMany(b => b.GameResults)
                .HasForeignKey(p => p.PlayerID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<GameResult>()
                .HasOne(p => p.Game)
                .WithMany(b => b.GameResults)
                .HasForeignKey(p => p.GameID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Game>()
                .HasOne(p => p.Player1Status)
                .WithMany(b => b.Player1Games)
                .HasForeignKey(p => p.Player1StatusID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Game>()
                .HasOne(p => p.Player2Status)
                .WithMany(b => b.Player2Games)
                .HasForeignKey(p => p.Player2StatusID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Connection>()
                .HasOne(p => p.User)
                .WithMany(b => b.Connections)
                .HasForeignKey(p => p.UserID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
