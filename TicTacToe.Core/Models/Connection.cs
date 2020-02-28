namespace TicTacToe.Core.Models
{
    public class Connection
    {
        public int ID { get; set; }
        public string ConnectionID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
