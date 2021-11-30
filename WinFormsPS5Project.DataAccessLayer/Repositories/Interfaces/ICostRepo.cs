using System.Collections.Generic;
using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.ViewModels;

namespace WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces
{
    public interface ICostRepo
    {
        CostModel GetCostById(int id);
        List<CostModel> GetAllCosts();
    }
}
