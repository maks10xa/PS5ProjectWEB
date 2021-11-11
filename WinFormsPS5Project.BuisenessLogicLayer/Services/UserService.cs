using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPS5Project.BuisenessLogicLayer.Services.Interfaces;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;
using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.Repositories;
using WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces;

namespace WinFormsPS5Project.BuisenessLogicLayer.Services
{
    public class UserService : IUserService
    {
        private PS5ProjContext _pS5ProjContext;
        private IUserRepo _userRepo;
        private IMapper _mapper;

        public UserService(PS5ProjContext pS5ProjContext, IUserRepo userRepo, IMapper mapper)
        {
            _pS5ProjContext = pS5ProjContext;
            _userRepo = userRepo;
            _mapper = mapper;
        }

        public void Add(UsersModel user)
        {
            var user1 = _mapper.Map<User>(user);

            _userRepo.Add(user1);
            _pS5ProjContext.SaveChanges();
        }

        public UsersModel GetUserByLogin(string login, string password)
        {
            var user = _userRepo.GetUserByLogin(login, password);
            var user1 = _mapper.Map<UsersModel>(user);

            return user1;
        }

        public bool IsUserConsistInDB(string login)
        {
            var user = _userRepo.IsUserConsistInDB(login);

            var user1 = _mapper.Map<bool>(user);

            return user1;
        }

        public void AddFavoriteGame(UsersModel user, string game)
        {
            var u = _mapper.Map<User>(user);

            _userRepo.AddFavoriteGame(u, game);

            _pS5ProjContext.SaveChanges();
        }
    }
}
