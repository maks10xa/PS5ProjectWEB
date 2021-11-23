using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS5Project.Web.MVC.Models
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string UserLogin { get; set; }
        public string Pass { get; set; }
        public string UserName { get; set; }
        public string FavoriteGame { get; set; }

        public UserDTO()
        {

        }
    }
}
