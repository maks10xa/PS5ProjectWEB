using System.Collections.Generic;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;

namespace WinFormsPS5Project.BuisenessLogicLayer.Services.Interfaces
{
    public interface IGameService
    {
        List<GamesModel> GetAllGames();
        GamesModel GetGameByName(string name);
    }
}
