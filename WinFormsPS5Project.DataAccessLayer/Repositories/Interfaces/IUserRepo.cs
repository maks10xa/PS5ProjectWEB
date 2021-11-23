using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.ViewModels;

namespace WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces
{
    public interface IUserRepo
    {
        void Add(UserModel user);
        User GetUserByLogin(string login, string password);
        bool IsUserConsistInDB(string login);
    }
}
