using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces;

namespace WinFormsPS5Project.DataAccessLayer.Repositories
{
    public class ContactRepo : IContactRepo
    {
        private PS5ProjContext _pS5ProjContext;

        public ContactRepo(PS5ProjContext pS5ProjContext)
        {
            _pS5ProjContext = pS5ProjContext;
        }

        public string GetAdminNumberByUserId(int id)
        {
            var number = _pS5ProjContext.Contacts.FirstOrDefault(n => n.UserId == id);

            return number.PhoneNumber;
        }
    }
}
