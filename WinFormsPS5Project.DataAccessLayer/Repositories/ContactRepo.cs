using System.Linq;
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

        public Contact GetAdmin(int id)
        {
            var cont = _pS5ProjContext.Contacts.FirstOrDefault(c => c.UserId == id);

            return cont;
        }
    }
}
