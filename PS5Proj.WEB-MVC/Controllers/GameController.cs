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
    }
}
