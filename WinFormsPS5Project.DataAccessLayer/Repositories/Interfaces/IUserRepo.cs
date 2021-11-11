using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPS5Project.DataAccessLayer.Models;

namespace WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces
{
    public interface IUserRepo
    {
        void Add(User user);
        User GetUserByLogin(string login, string password);
        bool IsUserConsistInDB(string login);
        void AddFavoriteGame(User user, string game);
    }
}
