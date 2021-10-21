using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces;

namespace WinFormsPS5Project.DataAccessLayer.Repositories
{
    class GameRepo : IGameRepo
    {
        private PS5ProjContext _pS5ProjContext;
        public List<Game> GetAllGames()
        {
            throw new NotImplementedException();
        }

        public Game GetGame(int id)
        {
            throw new NotImplementedException();
        }

        public Game GetGenre(int id)
        {
            throw new NotImplementedException();
        }
    }
}
