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

        public GameRepo(PS5ProjContext pS5ProjContext)
        {
            pS5ProjContext = _pS5ProjContext;
        }

        public List<Game> GetAllGames()
        {
            return _pS5ProjContext.Games.ToList();
        }

    }
}
