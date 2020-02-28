using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TicTacToe.Core.Models;
using TicTacToe.Core.Services;
using TicTacToe.Web.Models.GameSection;

namespace TicTacToe.Web.Controllers
{
    [Authorize]
    public class GameController : Controller
    {
        private readonly IGameService gameService;

        public GameController(IGameService gameService)
        {
            this.gameService = gameService;
        }

        [HttpGet]
        public IActionResult Play(int gameID)
        {
            Game game = gameService.GetGame(gameID);
            if (User.Identity.Name != game.Player1.NickName && User.Identity.Name != game.Player2.NickName)
            {
                return NotFound();
            }

            var model = new GameViewModel(gameID, User.Identity.Name, gameService);
            return View(model);
        }

        [HttpGet]
        public IActionResult PlayPartial(int gameID)
        {
            var model = new GameViewModel(gameID, User.Identity.Name, gameService);
            return PartialView(model);
        }

        [HttpPost]
        public IActionResult Play(string player1, string player2)
        {
            Game newGame = gameService.CreateNewGame(player1, player2);
            var model = new GameViewModel(newGame.ID, User.Identity.Name, gameService);

            return PartialView("PlayPartial", model);
        }
    }
}