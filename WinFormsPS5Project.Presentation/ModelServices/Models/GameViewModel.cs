using System;

namespace WinFormsPS5Project.Presentation.ModelServices.Models
{
    public class GameViewModel
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameGenre { get; set; }
        public DateTime? ReleaseDate { get; set; }
    }
}
