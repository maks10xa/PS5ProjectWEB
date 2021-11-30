using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;

namespace WinFormsPS5Project.BuisenessLogicLayer.Services.Interfaces
{
    public interface IUserService
    {
        void Add(UsersModel userModel);
        UsersModel GetUserByLogin(string login, string password);
        bool IsUserConsistInDB(string login);
        void SetFavoriteGame(UsersModel userModel, string favoriteGame);
        bool DoesUserIsAdmin(string login);
    }
}
