using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS5Proj.WEB_MVC.Models
{
    public class UserGame
    {
        public string UserLogin { get; set; }
        public string FavoriteGame { get; set; }
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string Img { get; set; }
        public string GameGenre { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
