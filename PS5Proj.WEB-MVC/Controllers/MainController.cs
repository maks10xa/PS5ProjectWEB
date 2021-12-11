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
        private IGameService _gameService;
        private IMapper _mapper;

        public MainController(IMapper mapper)
        {
            _mapper = mapper;
            _gameService = new GameService(mapper);
        }
        public IActionResult Index()
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
        //[HttpPost]
        //public string Update(GameMVC game)
        //{
        //    _gameService.SetGameProperties(game, ViewBag.GameName, ViewBag.GameGenre, ViewBag.ReleaseDate, ViewBag.Img);

        //    return Constant.SuccesfullyAddGame;
        //}
    }
}
