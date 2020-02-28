using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Core.Models
{
    public class Game
    {
        public int ID { get; set; }
        public int? Player1ID { get; set; }
        public int? Player2ID { get; set; }
        public int? Player1StatusID { get; set; }
        public int? Player2StatusID { get; set; }
        public User Player1 { get; set; }
        public User Player2 { get; set; }
        public PlayerStatus Player1Status { get; set; }
        public PlayerStatus Player2Status { get; set; }
        public bool IsOver { get; set; }
        public ICollection<Move> Moves { get; set; }
        public ICollection<GameResult> GameResults { get; set; }

    }
}
