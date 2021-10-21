using WinFormnsPS5Project.BuisenessLogicLayer.Services;
using WinFormnsPS5Project.WebApplication.Presentation.Models.DeveloperViewModel;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WinFormnsPS5Project.WebApplication.Presentation.Controllers
{
    public class UserController : Controller
    {
        private UserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }

        public IActionResult Index()
        {
            var users = _userService.GetList();

            UsersViewModel usersView = new UsersViewModel()
            { Users = new List<UserViewModel>() };

            foreach(var item in users)
            {
                UserViewModel user = new UserViewModel()
                {
                    Age = item.Age,
                    name = item.Name
                };
                usersView.Users.Add(user);
            }
            return View(usersView);
        }

        [HttpPost]
        public IActionResult Add([FromForm]AddUserDTO addUserDTO)
        {
            _userService.Add(addUserDTO.Name, addUserDTO.Age);
            return RedirectToAction("Index");
        }
    }
}
