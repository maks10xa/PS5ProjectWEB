using AutoMapper;
using Microsoft.Data.SqlClient;
using System.Linq;
using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces;
using WinFormsPS5Project.DataAccessLayer.ViewModels;

namespace WinFormsPS5Project.DataAccessLayer.Repositories
{
    public class UserRepo : IUserRepo
    {
        private PS5ProjContext _pS5ProjContext;
        private IMapper _mapper;

        public UserRepo(PS5ProjContext pS5ProjContext)
        {
            _pS5ProjContext = pS5ProjContext;

            var config = new AutoMapper.MapperConfiguration(c => c.AddProfile(new MapperProfile()));
            _mapper = config.CreateMapper();
        }

        public void Add(UserModel userModel)
        {
            var user = _mapper.Map<User>(userModel);
            _pS5ProjContext.Users.Add(user);
        }

        public UserModel GetUserByLogin(string login, string password)
        {
            var us = _pS5ProjContext.Users.Select(u => new UserModel()
            {
                Id = u.Id,
                UserLogin = u.UserLogin,
                Pass = u.Pass,
                UserName = u.UserName,
                FavoriteGame = u.FavoriteGame

            }).First(u => u.UserLogin == login);

          return us;
          }

        public bool IsUserConsistInDB(string login)
        {
            var isUser = _pS5ProjContext.Users.Any(u => u.UserLogin == login);

            return isUser;
        }

        public bool DoesUserIsAdmin(string login)
        {
            var isAdmin = _pS5ProjContext.Users.Any(u => u.UserLogin == login && u.IsAdminPs);

            return isAdmin;
        }

        public void SetFavoriteGame(UserModel userModel, string favoriteGame)
        {
            var user = _pS5ProjContext.Users.Select(u => new UserModel()
                {
                    Id = u.Id,
                    UserLogin = u.UserLogin,
                    Pass = u.Pass,
                    UserName = u.UserName,
                    FavoriteGame = u.FavoriteGame
                }).First(u => u.Id == userModel.Id);

            user.FavoriteGame = favoriteGame;

            var mapped = _mapper.Map<User>(user);
            _pS5ProjContext.Users.Update(mapped);
        }

      /*  public void GetAllAdmins()
        {
            using (var db = new PS5ProjContext())
            {
                var isAdminParametr = new SqlParameter("@IsAdminPS", 1);

                var result = db.Database
                    .SqlQuery<SelectAllAdmins>("SelectAllAdmins @IsAdminPS", isAdminParametr)
                    .ToList();
            }
        }*/
    }
}
