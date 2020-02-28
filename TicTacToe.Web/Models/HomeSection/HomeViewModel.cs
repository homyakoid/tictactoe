using System.Collections.Generic;
using System.Linq;
using TicTacToe.Core.Interfaces;
using TicTacToe.Core.Models;
using TicTacToe.Core.Services;

namespace TicTacToe.Web.Models.HomeSection
{
    public class HomeViewModel
    {
        public IList<User> Players { get; set; }
        public HomeViewModel(string userName, IUserService userService)
        {
            Players = userService.GetActiveUsersList(userName);
        }
    }
}
