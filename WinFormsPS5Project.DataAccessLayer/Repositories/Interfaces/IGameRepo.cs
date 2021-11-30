using System.Collections.Generic;
using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.ViewModels;

namespace WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces
{
    public interface IGameRepo
    {
        List<GameModel> GetAllGames();
        GameModel GetGameByName(string name);
    }
}
