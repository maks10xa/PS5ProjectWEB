﻿using AutoMapper;
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
    public class GameService : IGameService
    {
        private PS5ProjContext _pS5ProjContext;
        private IGameRepo _gameRepo;
        private IMapper _mapper;
        
        public GameService(IMapper mapper)
        {
            _pS5ProjContext = new PS5ProjContext();
            _gameRepo = new GameRepo(_pS5ProjContext);
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
