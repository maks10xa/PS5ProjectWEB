using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPS5Project.DataAccessLayer.ViewModels
{
    class GameModel
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameGenre { get; set; }
        public DateTime? ReleaseDate { get; set; }
    }
}
