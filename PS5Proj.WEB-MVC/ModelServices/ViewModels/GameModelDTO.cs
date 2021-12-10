using System;

namespace PS5Proj.WEB_MVC
{
    public class GameModelDTO
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameGenre { get; set; }
        public DateTime? ReleaseDate { get; set; }

    }
}
