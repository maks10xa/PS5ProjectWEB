using System.Collections.Generic;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;
using WinFormsPS5Project.Presentation.ModelServices.Interfaces;

namespace WinFormsPS5Project.Presentation.ModelServices
{
    public class Games : IGames
    {
        public List<GamesModel> Game { get; set; }

        public Games()
        {
            Game = new List<GamesModel>();
        }
    }
}
