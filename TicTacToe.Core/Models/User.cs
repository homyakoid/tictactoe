using System.Collections.Generic;

namespace TicTacToe.Core.Models
{
    public class User
    {
        public int ID { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
        public bool IsOnline { get; set; }
        public bool IsPlaying { get; set; }
        public ICollection<Game> Player1Games { get; set; }
        public ICollection<Game> Player2Games { get; set; }
        public ICollection<Move> Moves { get; set; }
        public ICollection<GameResult> GameResults { get; set; }
        public ICollection<Connection> Connections { get; set; }
    }
}
