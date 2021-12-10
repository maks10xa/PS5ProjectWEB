using PS5Proj.WEB_MVC.ModelServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;

namespace PS5Proj.WEB_MVC.ModelServices.Services
{
    public class UserPresentation : IUserPresentation
    {
        public UsersModel User { get; set; }

        public UserPresentation()
        {
            User = new UsersModel();
        }
    }
}
