using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PS5Proj.WEB_MVC.Models;
using PS5Proj.WEB_MVC.ModelServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WinFormsPS5Project.BuisenessLogicLayer.Services.Interfaces;

namespace PS5Proj.WEB_MVC.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private IUserService _userService;
        private IMapper _mapper;

        public AccountController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View(new LoginViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = _mapper.Map<UserModelDTO>(_userService.GetUserByLogin(model.UserLogin));

                if (user != null && model.Password == user.Pass)
                {
                    await Authenticate(model.UserLogin);

                    return Redirect(returnUrl ?? "/");
                }
                ModelState.AddModelError(nameof(LoginViewModel.UserLogin), "Неверный логин или пароль!");
            }
            return View(model);
        }

        private async Task Authenticate(string email)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, email)
            };

            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}
