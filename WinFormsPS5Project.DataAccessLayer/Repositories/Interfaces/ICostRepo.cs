using System.Collections.Generic;
using WinFormsPS5Project.DataAccessLayer.Models;

namespace WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces
{
    public interface ICostRepo
    {
        Cost GetCostById(int id);
        List<Cost> GetAllCosts();
    }
}
