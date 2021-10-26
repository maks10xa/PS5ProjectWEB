using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;
using WinFormsPS5Project.DataAccessLayer.Repositories;

namespace WinFormsPS5Project.Presentation.ModelServices.Interfaces
{
    public interface IUserAccaunt
    {
        UsersModel User { get; set; }
    }
}
