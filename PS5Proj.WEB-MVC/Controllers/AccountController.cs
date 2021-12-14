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
    public class AccountController : Controller
    {
        private IUserService _userService;
        private IMapper _mapper;

        public AccountController(IMapper mapper)
        {
            _mapper = mapper;
            _userService = new UserService(_mapper);
        }

        [Authorize]
        public IActionResult Profile()
        {
            var login = User.Claims.FirstOrDefault(t => t.Type == ClaimTypes.Name).Value;
            var user = _mapper.Map<UserMVC>(_userService.GetUserByLogin(login));

            return View(user);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Pay(decimal cost)
        {
            var userName = User.FindFirst(ClaimTypes.Name).Value;
            var user = _userService.GetUserByLogin(userName);

            if (user.Balance < cost)
            {
                return RedirectToAction("TopUpBalance", "Account");
            }
            else
            {
                _userService.PayOrder(user, cost);
            }
            
            return View();
        }

        [HttpGet]
        public IActionResult TopUpBalance(int? id)
        {
            if (id == null) return RedirectToAction("Profile");
            ViewBag.UserId = id;

            return View();
        }
        [HttpPost]
        public string TopUpBalance(UserMVC user)
        {
            var mapped = _mapper.Map<UsersModel>(user);
            _userService.Refill(mapped, user.Cost);

            return Constant.SuccessfullyRefill;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _mapper.Map<UserMVC>(_userService.GetUserByLogin(model.Login));

                if (user != null && user.Pass == model.Password)
                {
                    await Authenticate(model.Login);

                    return RedirectToAction("Profile", "Account"); 
                }
                ModelState.AddModelError("", "Неверный логин или пароль!");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _userService.GetUserByLogin(model.Login);
                if (user == null)
                {
                    _userService.Add(new UsersModel { UserName = model.Name, UserLogin = model.Login, Pass = model.Password });

                    await Authenticate(model.Login); 

                    return RedirectToAction("Profile", "Account"); 
                }
                else
                    ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }

        private async Task Authenticate(string login)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, login),
            };

            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}
