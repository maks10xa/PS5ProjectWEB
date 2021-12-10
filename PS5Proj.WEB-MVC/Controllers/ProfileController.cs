using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WinFormsPS5Project.BuisenessLogicLayer.Services.Interfaces;

namespace PS5Proj.WEB_MVC.Controllers
{
    public class ProfileController : Controller
    {
        private IUserService _userService;
        private IMapper _mapper;

        public ProfileController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
