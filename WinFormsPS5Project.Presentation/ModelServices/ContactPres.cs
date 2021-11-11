using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;
using WinFormsPS5Project.Presentation.ModelServices.Interfaces;

namespace WinFormsPS5Project.Presentation.ModelServices
{
    public class ContactPres : IContactPres
    {
        public ContactsModel Contact { get; set; }

        public ContactPres()
        {
            Contact = new ContactsModel();
        }
    }
}
