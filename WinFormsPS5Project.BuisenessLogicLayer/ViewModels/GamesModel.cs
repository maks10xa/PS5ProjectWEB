using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPS5Project.DataAccessLayer.Models;

namespace WinFormsPS5Project.BuisenessLogicLayer.ViewModels
{
    public class GamesModel
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameGenre { get; set; }
        public DateTime? ReleaseDate { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
