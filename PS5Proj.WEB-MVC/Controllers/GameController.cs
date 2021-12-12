using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PS5Proj.WEB_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WinFormsPS5Project.BuisenessLogicLayer.Services;
using WinFormsPS5Project.BuisenessLogicLayer.Services.Interfaces;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;

namespace PS5Proj.WEB_MVC.Controllers
{
    [Authorize]
    public class GameController : Controller
    {
        private IUserService _userService;
        private IGameService _gameService;
        private IMapper _mapper;

        public GameController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
            _gameService = new GameService(mapper);
        }
        public IActionResult Index()
        {
            var a = _gameService.GetAllGames();
            var model = _mapper.Map<List<GameMVC>>(a);

            return View(model);
        }

        [HttpPost]
        public IActionResult Info(string name)
        {
            var game = _gameService.GetGameByName(name);
            var mappedGame = _mapper.Map<GameMVC>(game);

            return View(mappedGame);
        }

        [HttpPost]
        public IActionResult AddToFavorite(string name)
        {
            var userName = User.FindFirst(ClaimTypes.Name).Value;
            var user = _userService.GetUserByLogin(userName);

            _userService.SetFavoriteGame(user, name);

            return NoContent();
        }

        [HttpGet]
        public IActionResult AddGame()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddGame(AddGame model)
        {
            if (ModelState.IsValid)
            {
                var game = _gameService.GetGameByName(model.GameName);
                if (game == null)
                {
                    _gameService.AddGame(new GamesModel { GameName = model.GameName, GameGenre = model.GameGenre, ReleaseDate = model.ReleaseDate, Img = model.Image });

                    await Authenticate(model.GameName);

                    return RedirectToAction("Index", "Game"); 
                }
                else
                    ModelState.AddModelError("", "Эта игра уже добавлена!");
            }
            return View(model);
        }

        private async Task Authenticate(string name)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, name)
            };

            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}
