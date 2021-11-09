using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPS5Project.BuisenessLogicLayer.Services.Interfaces;
using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;

namespace WinFormsPS5Project.BuisenessLogicLayer.Services
{
    public class ContactService : IContactService
    {
        private PS5ProjContext _pS5ProjContext;
        private IContactRepo _contactRepo;
        private IMapper _mapper;

        public ContactService(PS5ProjContext pS5ProjContext, IContactRepo contactRepo, IMapper mapper)
        {
            _pS5ProjContext = pS5ProjContext;
            _contactRepo = contactRepo;
            _mapper = mapper;
        }

        public string GetAdminNumberByUserId(int id)
        {
            var number = _contactRepo.GetAdminNumberByUserId(id);

            return number;
        }
    }
}
