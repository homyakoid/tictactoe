using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TicTacToe.Core.Interfaces;
using TicTacToe.Core.Models;
using TicTacToe.Core.Services;
using TicTacToe.Web.Models.HomeSection;

namespace TicTacToe.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IGameService gameService;
        private readonly IUserService userService;

        public HomeController(IGameService gameService, IUserService userService)
        {
            this.gameService = gameService;
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            int? gameID = gameService.GetActiveGame(User.Identity.Name);
            if (gameID.HasValue)
            {
                return RedirectToAction("Play", "Game", new { gameID = gameID.Value });
            }

            var model = new HomeViewModel(User.Identity.Name, userService);
            return View(model);
        }

        [HttpGet]
        public IActionResult IndexPartial()
        {
            var model = new HomeViewModel(User.Identity.Name, userService);
            return PartialView(model);
        }
    }
}
