using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Core.Models
{
    public class Move
    {
        public int ID { get; set; }
        public int GameID { get; set; }
        public int PlayerID { get; set; }
        public int MovePosition { get; set; }
        public Game Game { get; set; }
        public User Player { get; set; }
    }
}
