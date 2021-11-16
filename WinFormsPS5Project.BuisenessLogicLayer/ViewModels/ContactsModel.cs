using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPS5Project.DataAccessLayer.Models;

namespace WinFormsPS5Project.BuisenessLogicLayer.ViewModels
{
    public class ContactsModel
    {
        public int Id { get; set; }
        public string AdminName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
