using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPS5Project.BuisenessLogicLayer.Services.Interfaces;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;
using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces;

namespace WinFormsPS5Project.BuisenessLogicLayer.Services
{
    class UserService : IUserService
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
            throw new NotImplementedException();
        }

        public UsersModel GetUserByLogin(string login, string password)
        {
            throw new NotImplementedException();
        }

        public bool IsUserConsistInDB(string login)
        {
            throw new NotImplementedException();
        }
    }
}
