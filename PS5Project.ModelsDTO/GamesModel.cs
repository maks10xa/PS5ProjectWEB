using System;

namespace WinFormsPS5Project.BuisenessLogicLayer.ViewModels
{
    public class GamesModel
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameGenre { get; set; }
        public DateTime? ReleaseDate { get; set; }

    }
}
