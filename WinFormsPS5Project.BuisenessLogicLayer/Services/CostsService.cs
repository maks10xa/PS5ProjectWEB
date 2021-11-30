using AutoMapper;
using System.Collections.Generic;
using WinFormsPS5Project.BuisenessLogicLayer.Services.Interfaces;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;
using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.Repositories;
using WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces;

namespace WinFormsPS5Project.BuisenessLogicLayer.Services
{
    public class CostsService : ICostsService
    {
        private PS5ProjContext _pS5ProjContext;
        private ICostRepo _costRepo;
        private IMapper _mapper;

        public CostsService(IMapper mapper)
        {
            _pS5ProjContext = new PS5ProjContext();
            _costRepo = new CostRepo(_pS5ProjContext);
            _mapper = mapper;
        }

        public CostsModel GetCostById(int id)
        {
            var cost = _costRepo.GetCostById(id);
            var costModel = _mapper.Map<CostsModel>(cost);
            return costModel;
        }

        public List<CostsModel> GetAllCosts()
        {
            var costs = _costRepo.GetAllCosts();
            var mapped = _mapper.Map<List<CostsModel>>(costs);

            return mapped;
        }
    }
}
