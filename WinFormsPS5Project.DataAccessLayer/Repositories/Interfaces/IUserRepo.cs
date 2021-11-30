using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.ViewModels;

namespace WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces
{
    public interface IUserRepo
    {
        void Add(UserModel user);
        UserModel GetUserByLogin(string login, string password);
        bool IsUserConsistInDB(string login);
        void SetFavoriteGame(UserModel userModel, string favoriteGame);
        bool DoesUserIsAdmin(string login);
    }
}
