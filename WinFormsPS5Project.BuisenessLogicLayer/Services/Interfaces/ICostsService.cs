using System.Collections.Generic;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;

namespace WinFormsPS5Project.BuisenessLogicLayer.Services.Interfaces
{
    public interface ICostsService
    {
        List<CostsModel> GetAllCosts();
        CostsModel GetCostById(int id);
    }
}
