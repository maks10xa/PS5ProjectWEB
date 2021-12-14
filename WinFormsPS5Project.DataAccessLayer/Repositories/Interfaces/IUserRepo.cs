using System.Collections.Generic;
using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.ViewModels;

namespace WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces
{
    public interface IUserRepo
    {
        void Add(UserModel user);
        List<UserModel> GetAllUsers();
        UserModel GetUserByLogin(string login);
        bool DoesUserExistInDb(string login);
        void SetFavoriteGame(UserModel userModel, string favoriteGame);
        bool DoesUserIsAdmin(string login);
        void Refill(UserModel userModel, decimal cost);
        void PayOrder(UserModel userModel, decimal cost);
    }
}
