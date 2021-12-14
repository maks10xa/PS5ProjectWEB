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
        private ICostsService _costsService;
        private IContactService _contactService;
        private IMapper _mapper;

        public MainController(IMapper mapper)
        {
            _mapper = mapper;
            _gameService = new GameService(mapper);
            _costsService = new CostsService(mapper);
            _contactService = new ContactService(mapper);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test()
        {
            var game = _gameService.GetAllGames();
            var gameModel = _mapper.Map<List<GameMVC>>(game);

            return View(gameModel);
        }

        public IActionResult Costs()
        {
            var costs = _costsService.GetAllCosts();
            var costModel = _mapper.Map<List<CostMVC>>(costs);

            return View(costModel);
        }

        public IActionResult Info()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            var contacts = _contactService.GetAdminsContacts();
            var contactsModel = _mapper.Map<List<ContactMVC>>(contacts);

            return View(contactsModel);
        }
    }
}
