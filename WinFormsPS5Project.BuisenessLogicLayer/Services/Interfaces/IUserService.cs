﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;
using WinFormsPS5Project.DataAccessLayer.ViewModels;

namespace WinFormsPS5Project.BuisenessLogicLayer.Services.Interfaces
{
    public interface IUserService
    {
        void Add(UsersModel userModel);
        List<UsersModel> GetAllUsers();
        UsersModel GetUserByLogin(string login, string password);
        bool DoesUserExistInDb(string login);
        void SetFavoriteGame(UsersModel userModel, string favoriteGame);
        bool DoesUserIsAdmin(string login);
    }
}
