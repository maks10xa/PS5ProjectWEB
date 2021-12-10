using PS5Proj.WEB_MVC.ModelServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;

namespace PS5Proj.WEB_MVC.ModelServices.Services
{
    public class ContactPresentation : IContactPresentation
    {
        public ContactsModel Contact { get; set; }

        public ContactPresentation()
        {
            Contact = new ContactsModel();
        }
    }
}
