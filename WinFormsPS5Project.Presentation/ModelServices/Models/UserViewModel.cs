namespace WinFormsPS5Project.Presentation.ModelServices.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string UserLogin { get; set; }
        public string Pass { get; set; }
        public string UserName { get; set; }
        public bool IsAdminPs { get; set; }
        public string FavoriteGame { get; set; }
    }
}
