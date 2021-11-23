using System.Collections.Generic;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;

namespace WinFormsPS5Project.Presentation.ModelServices.Interfaces
{
    public interface IGames
    {
        List<GamesModel> Game { get; set; }
    }
}
