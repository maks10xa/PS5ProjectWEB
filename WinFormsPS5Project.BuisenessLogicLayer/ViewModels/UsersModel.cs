using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPS5Project.DataAccessLayer.Models;

namespace WinFormsPS5Project.BuisenessLogicLayer.ViewModels
{
    public class UsersModel
    {
        public int Id { get; set; }
        public string UserLogin { get; set; }
        public string Pass { get; set; }
        public string UserName { get; set; }
        public bool AdminPs { get; set; }
        public string FavoriteGame { get; set; }
        public int? GameId { get; set; }
        public virtual Game Game { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
