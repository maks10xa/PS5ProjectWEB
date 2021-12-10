using PS5Proj.WEB_MVC.ModelServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;

namespace PS5Proj.WEB_MVC.ModelServices.Services
{
    public class GamePresentation : IGamePresentation
    {
        public List<GamesModel> Game { get; set; }

        public GamePresentation()
        {
            Game = new List<GamesModel>();
        }
    }
}
