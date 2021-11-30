using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces;
using WinFormsPS5Project.DataAccessLayer.ViewModels;

namespace WinFormsPS5Project.DataAccessLayer.Repositories
{
    public class CostRepo : ICostRepo
    {
        private PS5ProjContext _pS5ProjContext;
        private IMapper _mapper;

        public CostRepo(PS5ProjContext pS5ProjContext)
        {
            _pS5ProjContext = pS5ProjContext;

            var config = new AutoMapper.MapperConfiguration(c => c.AddProfile(new MapperProfile()));
            _mapper = config.CreateMapper();
        }
        public CostModel GetCostById(int id)
        {
            var cost = _pS5ProjContext.Costs.Select(c => new CostModel()
            {
                Id = c.Id,
                TimePeriod = c.TimePeriod,
                CostOfPeriod = c.CostOfPeriod
            }).FirstOrDefault();

            return cost;
        }

        public List<CostModel> GetAllCosts()
        {
            var costs = _pS5ProjContext.Costs.ToList();
            var mapped = _mapper.Map<List<CostModel>>(costs);

            return mapped;
        }
    }
}
