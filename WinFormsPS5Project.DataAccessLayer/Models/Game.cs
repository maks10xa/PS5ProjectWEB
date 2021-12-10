using System;
using System.Collections.Generic;

#nullable disable

namespace WinFormsPS5Project.DataAccessLayer.Models
{
    public partial class Game
    {
        public Game()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameGenre { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Img { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
