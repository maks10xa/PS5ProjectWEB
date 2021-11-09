using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPS5Project.BuisenessLogicLayer.Services.Interfaces
{
    interface IContactService
    {
        string GetAdminNumberByUserId(int id);
    }
}
