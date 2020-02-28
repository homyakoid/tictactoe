using System.Collections.Generic;

namespace TicTacToe.Core.Models
{
    public class PlayerStatus
    {
        public int ID { get; set; }
        public string Status { get; set; }
        public ICollection<Game> Player1Games { get; set; }
        public ICollection<Game> Player2Games { get; set; }
    }
}
