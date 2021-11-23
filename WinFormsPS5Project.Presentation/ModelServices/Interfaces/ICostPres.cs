using System.Collections.Generic;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;

namespace WinFormsPS5Project.Presentation.ModelServices.Interfaces
{
    interface ICostPres
    {
        List<CostsModel> Cost { get; set; }
    }
}
