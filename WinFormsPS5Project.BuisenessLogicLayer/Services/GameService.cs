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
    public class GameService : IGameService
    {
        private PS5ProjContext _pS5ProjContext;
        private IGameRepo _gameRepo;
        private IMapper _mapper;
        
        public GameService(PS5ProjContext pS5ProjContext, IGameRepo gameRepo, IMapper mapper)
        {
            _pS5ProjContext = pS5ProjContext;
            _gameRepo = gameRepo;
            _mapper = mapper;
        }

        public List<GamesModel> GetAllGames()
        {
            var games = _mapper.Map<List<GamesModel>>(_gameRepo.GetAllGames());

            return games;
        }

        public GamesModel GetGameByName(string name)
        {
            var game = _gameRepo.GetGameByName(name);

            var game1 = _mapper.Map<GamesModel>(game);

            return game1;
        }
    }
}
