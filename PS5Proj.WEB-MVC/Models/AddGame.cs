using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PS5Proj.WEB_MVC.Models
{
    public class AddGame
    {
        [Required(ErrorMessage = "Название игры не указано!")]
        public string GameName { get; set; }
        public string GameGenre { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Image { get; set; }
    }
}
