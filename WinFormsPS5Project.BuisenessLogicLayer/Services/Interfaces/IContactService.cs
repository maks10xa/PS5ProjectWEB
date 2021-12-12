using System.Collections.Generic;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;

namespace WinFormsPS5Project.BuisenessLogicLayer.Services.Interfaces
{
    public interface IContactService
    {
        ContactsModel GetAdmin(int id);
        List<ContactsModel> GetAdminsContacts();
    }
}
