using AutoMapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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

        public List<UserModel> GetAllUsers()
        {
            var users = _pS5ProjContext.Users.ToList();
            var mapped = _mapper.Map<List<UserModel>>(users);

            return mapped;
        }

        public UserModel GetUserByLogin(string login)
        {
            var us = _pS5ProjContext.Users.FirstOrDefault(u => u.UserLogin == login);
            var mapped = _mapper.Map<UserModel>(us);

            return mapped;
          }

        public bool DoesUserExistInDb(string login)
        {
            var isUser = _pS5ProjContext.Users.Any(u => u.UserLogin == login);

            return isUser;
        }

        public bool DoesUserIsAdmin(string login)
        {
            var isAdmin = _pS5ProjContext.Users.Any(u => u.UserLogin == login && u.AdminPs);

            return isAdmin;
        }

        public void SetFavoriteGame(UserModel userModel, string favoriteGame)
        {
            var user = _pS5ProjContext.Users.FirstOrDefault(u => u.Id == userModel.Id);
            user.FavoriteGame = favoriteGame;
        }

        public void Refill(UserModel userModel, decimal cost)
        {
            var user = _pS5ProjContext.Users.FirstOrDefault(u => u.Id == userModel.Id);
            user.Balance += cost;
        }

        public void PayOrder(UserModel userModel, decimal cost)
        {
            var user = _pS5ProjContext.Users.FirstOrDefault(u => u.Id == userModel.Id);
            user.Balance -= cost;
        }
    }
}
   
