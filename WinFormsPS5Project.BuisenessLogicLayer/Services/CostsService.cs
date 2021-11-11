using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPS5Project.BuisenessLogicLayer.Services.Interfaces;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;
using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces;

namespace WinFormsPS5Project.BuisenessLogicLayer.Services
{
    public class CostsService : ICostsService
    {
        private PS5ProjContext _pS5ProjContext;
        private ICostRepo _costRepo;
        private IMapper _mapper;

        public CostsService(PS5ProjContext pS5ProjContext, ICostRepo costRepo, IMapper mapper)
        {
            _pS5ProjContext = pS5ProjContext;
            _costRepo = costRepo;
            _mapper = mapper;
        }

        public CostsModel GetCostById(int id)
        {
            var cost = _costRepo.GetCostById(id);
            var cost1 = _mapper.Map<CostsModel>(cost);
            return cost1;
        }

        public List<CostsModel> GetAllCosts()
        {
            var costs = _mapper.Map<List<CostsModel>>(_costRepo.GetAllCosts());

            return costs;
        }
    }
}
