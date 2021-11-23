using System.Collections.Generic;
using WinFormsPS5Project.DataAccessLayer.Models;

namespace WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces
{
    public interface IGameRepo
    {
        List<Game> GetAllGames();
        Game GetGameByName(string name);
    }
}
