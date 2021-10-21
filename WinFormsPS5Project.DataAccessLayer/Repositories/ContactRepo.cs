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
        public Contact GetName(int id)
        {
            throw new NotImplementedException();
        }

        public Contact GetPhoneNumber(int id)
        {
            throw new NotImplementedException();
        }
    }
}
