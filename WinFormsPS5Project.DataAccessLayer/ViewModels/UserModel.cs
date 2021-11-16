using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPS5Project.DataAccessLayer.ViewModels
{
    public class UserModel
    {
        public int Id { get; set; }
        public string UserLogin { get; set; }
        public string Pass { get; set; }
        public string UserName { get; set; }
        public string FavoriteGame { get; set; }
    }
}
