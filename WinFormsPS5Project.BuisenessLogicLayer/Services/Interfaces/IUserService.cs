using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;
using WinFormsPS5Project.DataAccessLayer.Models;

namespace WinFormsPS5Project.BuisenessLogicLayer.Services.Interfaces
{
    public interface IUserService
    {
        void Add(UsersModel userModel);
        UsersModel GetUserByLogin(string login, string password);
        bool IsUserConsistInDB(string login);
    }
}
