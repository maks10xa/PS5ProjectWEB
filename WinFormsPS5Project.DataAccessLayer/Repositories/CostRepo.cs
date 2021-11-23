using System.Collections.Generic;
using System.Linq;
using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces;

namespace WinFormsPS5Project.DataAccessLayer.Repositories
{
    public class CostRepo : ICostRepo
    {
        private PS5ProjContext _pS5ProjContext;

        public CostRepo(PS5ProjContext pS5ProjContext)
        {
            _pS5ProjContext = pS5ProjContext;
        }
        public Cost GetCostById(int id)
        {
            var cost = _pS5ProjContext.Costs.FirstOrDefault(c => c.Id == id);
            return cost;
        }

        public List<Cost> GetAllCosts()
        {
            return _pS5ProjContext.Costs.ToList();
        }
    }
}
