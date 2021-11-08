using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPS5Project.BuisenessLogicLayer.ViewModels
{
    public class UsersModel
    {
        public string UserLogin { get; set; }
        public string Pass { get; set; }
        public string UserName { get; set; }
        public bool AdminPs { get; set; }
        public List<string> FavoriteGame { get; set; }        
    }
}
