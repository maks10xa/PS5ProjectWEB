using AutoMapper;
using WinFormsPS5Project.BuisenessLogicLayer.Services.Interfaces;
using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;
using WinFormsPS5Project.DataAccessLayer.Repositories;

namespace WinFormsPS5Project.BuisenessLogicLayer.Services
{
    public class ContactService : IContactService
    {
        private PS5ProjContext _pS5ProjContext;
        private IContactRepo _contactRepo;
        private IMapper _mapper;

        public ContactService(IMapper mapper)
        {
            _pS5ProjContext = new PS5ProjContext();
            _contactRepo = new ContactRepo(_pS5ProjContext);
            _mapper = mapper;
        }

        public ContactsModel GetAdmin(int id)
        {
            var cont = _contactRepo.GetAdmin(id);
            var contModel = _mapper.Map<ContactsModel>(cont);

            return contModel;
        }
    }
}
