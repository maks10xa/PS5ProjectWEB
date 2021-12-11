using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces;
using WinFormsPS5Project.DataAccessLayer.ViewModels;

namespace WinFormsPS5Project.DataAccessLayer.Repositories
{
    public class GameRepo : IGameRepo
    {
        private PS5ProjContext _pS5ProjContext;
        private IMapper _mapper;

        public GameRepo(PS5ProjContext pS5ProjContext)
        {
            _pS5ProjContext = pS5ProjContext;

            var config = new AutoMapper.MapperConfiguration(c => c.AddProfile(new MapperProfile()));
            _mapper = config.CreateMapper();
        }

        public List<GameModel> GetAllGames()
        {
            var games = _pS5ProjContext.Games.ToList();
            var mapped = _mapper.Map<List<GameModel>>(games);

            return mapped;
        }

        public GameModel GetGameByName(string name)
        {
            var game = _pS5ProjContext.Games.Select(g => new GameModel()
            {
                Id = g.Id,
                GameName = g.GameName,
                GameGenre = g.GameGenre,
                ReleaseDate = g.ReleaseDate
            }).FirstOrDefault();

            return game;
        }

        public void SetImgRef(GameModel gameModel, string img)
        {
            var game = _pS5ProjContext.Games.FirstOrDefault(i => i.Id == gameModel.Id);
            game.Img = img;
        }

        public void AddGame(GameModel gameModel)
        {
            var game = _mapper.Map<Game>(gameModel);
            _pS5ProjContext.Games.Add(game);
        }

        public void SetGameProperties(GameModel gameModel)
        {
            var game = _pS5ProjContext.Games.FirstOrDefault(g => g.Id == gameModel.Id);
            game.GameName = gameModel.GameName;
            game.GameGenre = gameModel.GameGenre;
            game.ReleaseDate = gameModel.ReleaseDate;
            game.Img = gameModel.Img;
        }
    }
}
