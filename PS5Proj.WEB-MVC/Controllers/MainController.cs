using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PS5Proj.WEB_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WinFormsPS5Project.BuisenessLogicLayer.Services;
using WinFormsPS5Project.BuisenessLogicLayer.Services.Interfaces;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;

namespace PS5Proj.WEB_MVC.Controllers
{
    public class MainController : Controller
    {
        private IGameService _gameService;
        private IMapper _mapper;

        public MainController(IMapper mapper)
        {
            _mapper = mapper;
            _gameService = new GameService(mapper);
        }

        //[Authorize]
        public IActionResult Index()
        {
            //return Content(User.Identity.Name);
            return View();
        }

        public IActionResult Test()
        {
            var a = _gameService.GetAllGames();
            var gameModel = _mapper.Map<List<GameMVC>>(a);

            return View(gameModel);
        }

        [HttpGet]
        public IActionResult Update(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.GameId = id;

            return View();
        }
        [HttpPost]
        public string Update(GameMVC game)
        {
            var a = _mapper.Map<GamesModel>(game);
            _gameService.SetGameProperties(a);

            return Constant.SuccesfullyAddGame;
        }
    }
}
