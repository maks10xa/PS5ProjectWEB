using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PS5Proj.WEB_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WinFormsPS5Project.BuisenessLogicLayer.Services;
using WinFormsPS5Project.BuisenessLogicLayer.Services.Interfaces;

namespace PS5Proj.WEB_MVC.Controllers
{
    public class MainController : Controller
    {
        private IUserService _userService;
        private IGameService _gameService;
        private IMapper _mapper;

        public MainController(IUserService userService, IMapper mapper)
        {
            _userService = new UserService(mapper);
            _mapper = mapper;
            _gameService = new GameService(mapper);
        }
        public IActionResult Index()
        {
            var a = _gameService.GetAllGames();
            var gameModel = _mapper.Map<List<GameMVC>>(a);

            //var b = _userService.GetAllUsers();
            //var userModel = _mapper.Map<List<UserMVC>>(b);

            return View(gameModel);
        }
    }
}
