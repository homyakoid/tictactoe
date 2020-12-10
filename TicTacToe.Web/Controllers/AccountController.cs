using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TicTacToe.Core.Interfaces;
using TicTacToe.Core.Models;
using TicTacToe.Core.Services;
using TicTacToe.Web.Models.AccountSection;

namespace TicTacToe.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService userService;
        private readonly IGameService gameService;
        private readonly IHashService hashService;

        public AccountController(IUserService userService, IGameService gameService, IHashService hashService)
        {
            this.userService = userService;
            this.gameService = gameService;
            this.hashService = hashService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                bool isUserValid = false;
                bool isUserPlaying = false;
                string passwordHashString = hashService.GetHash(model.Password);
                User user = userService.GetUserByNickName(model.NickName);

                if (user != null)
                {
                    if (string.Equals(user.Password, passwordHashString, System.StringComparison.InvariantCultureIgnoreCase))
                    {
                        if (user.IsPlaying)
                        {
                            isUserPlaying = true;
                        }

                        isUserValid = true;
                    }
                    else
                    {
                        return Forbid();
                    }
                }
                else
                {
                    user = userService.AddNewUser(model.NickName, passwordHashString);
                    isUserValid = true;
                }

                if (isUserValid)
                {
                    await Authenticate(user.NickName);
                }

                if (isUserPlaying)
                {
                    Game lastGame = gameService.GetLastGame(user.ID);
                    return Ok(lastGame.ID);
                }

                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        public async Task<IActionResult> Logoff()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Login", "Account");
        }

        private async Task Authenticate(string userName)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, userName)
            };
            var id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimTypes.NameIdentifier, ClaimTypes.NameIdentifier);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}