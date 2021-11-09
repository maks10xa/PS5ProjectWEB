using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces;

namespace WinFormsPS5Project.DataAccessLayer.Repositories
{
    public class UserRepo : IUserRepo
    {
        private PS5ProjContext _pS5ProjContext;

        public UserRepo(PS5ProjContext pS5ProjContext)
        {
            _pS5ProjContext = pS5ProjContext;
        }

        public void Add(User user)
        {
            User user1 = new User()
            {
                UserLogin = user.UserLogin,
                Pass = user.Pass,
                UserName = user.UserName
            };
            _pS5ProjContext.Users.Add(user1);
        }

        public User GetUserByLogin(string login, string password)
        {
            var user = _pS5ProjContext.Users.FirstOrDefault(u => u.UserLogin == login && u.Pass == password);

          return user;
          }

        public bool IsUserConsistInDB(string login)
        {
            var isUser = _pS5ProjContext.Users.Any(u => u.UserLogin == login);

            return isUser;
        }
    }
}
