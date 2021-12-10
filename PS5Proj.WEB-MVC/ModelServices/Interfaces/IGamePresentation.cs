using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;

namespace PS5Proj.WEB_MVC.ModelServices.Interfaces
{
    interface IGamePresentation
    {
        List<GamesModel> Game { get; set; }
    }
}
