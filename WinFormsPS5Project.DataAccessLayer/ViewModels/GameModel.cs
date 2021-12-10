using System;

namespace WinFormsPS5Project.DataAccessLayer.ViewModels
{
    public class GameModel
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameGenre { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Img { get; set; }
    }
}
