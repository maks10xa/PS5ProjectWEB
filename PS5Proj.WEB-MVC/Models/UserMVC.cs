using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS5Proj.WEB_MVC.Models
{
    public class UserMVC
    {
        public int Id { get; set; }
        public string UserLogin { get; set; }
        public string Pass { get; set; }
        public string UserName { get; set; }
        public bool IsAdminPs { get; set; }
        public string FavoriteGame { get; set; }
        public decimal? Balance { get; set; }
        public decimal Cost { get; set; }
    }
}
