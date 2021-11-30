using AutoMapper;
using WinFormsPS5Project.BuisenessLogicLayer.Services.Interfaces;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;
using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.Repositories;
using WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces;
using WinFormsPS5Project.DataAccessLayer.ViewModels;

namespace WinFormsPS5Project.BuisenessLogicLayer.Services
{
    public class UserService : IUserService
    {
        private PS5ProjContext _pS5ProjContext;
        private IUserRepo _userRepo;
        private IMapper _mapper;

        public UserService(IMapper mapper)
        {
            _pS5ProjContext =  new PS5ProjContext();
            _mapper = mapper;
            _userRepo = new UserRepo(_pS5ProjContext);
        }

        public void Add(UsersModel userModel)
        {
            var user = _mapper.Map<UserModel>(userModel);

            _userRepo.Add(user);
            _pS5ProjContext.SaveChanges();
        }

        public UsersModel GetUserByLogin(string login, string password)
        {
            var user = _userRepo.GetUserByLogin(login, password);
            var db = _mapper.Map<UsersModel>(user);

            return db;
        }

        public bool IsUserConsistInDB(string login)
        {
            var db = _userRepo.IsUserConsistInDB(login);

            //var user = _mapper.Map<bool>(db);

            return db;
        }

        public bool DoesUserIsAdmin(string login)
        {
            var db = _userRepo.DoesUserIsAdmin(login);

            return db;
        }

        public void SetFavoriteGame(UsersModel userModel, string favoriteGame)
        {
            var user = _mapper.Map<UserModel>(userModel);

            _userRepo.SetFavoriteGame(user, favoriteGame);
            _pS5ProjContext.SaveChanges();
        }
    }
}
