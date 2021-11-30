namespace PS5Proj.WEB_MVC
{
    public class UserModelDTO
    {
        public int Id { get; set; }
        public string UserLogin { get; set; }
        public string Pass { get; set; }
        public string UserName { get; set; }
        public bool IsAdminPs { get; set; }
        public string FavoriteGame { get; set; }
    }
}
