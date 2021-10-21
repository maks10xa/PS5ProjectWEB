using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WinFormnsPS5Project.WebApplication.Presentation.Models
{
    public class AddUserDTO : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
