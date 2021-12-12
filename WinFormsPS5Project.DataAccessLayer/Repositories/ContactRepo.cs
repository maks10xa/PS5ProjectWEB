using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces;
using WinFormsPS5Project.DataAccessLayer.ViewModels;

namespace WinFormsPS5Project.DataAccessLayer.Repositories
{
    public class ContactRepo : IContactRepo
    {
        private PS5ProjContext _pS5ProjContext;
        private IMapper _mapper;

        public ContactRepo(PS5ProjContext pS5ProjContext)
        {
            _pS5ProjContext = pS5ProjContext;

            var config = new AutoMapper.MapperConfiguration(c => c.AddProfile(new MapperProfile()));
            _mapper = config.CreateMapper();
        }

        public ContactModel GetAdmin(int id)
        {
            var cont = _pS5ProjContext.Contacts.Select(c => new ContactModel()
            {
                Id = c.Id,
                AdminName = c.AdminName,
                PhoneNumber = c.PhoneNumber
            }).FirstOrDefault();

            return cont;
        }

        public List<ContactModel> GetAdminsContacts()
        {
            var contacts = _pS5ProjContext.Contacts.ToList();
            var mapped = _mapper.Map<List<ContactModel>>(contacts);

            return mapped;
        }
    }
}
