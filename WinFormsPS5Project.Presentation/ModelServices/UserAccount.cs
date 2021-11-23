using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;
using WinFormsPS5Project.Presentation.ModelServices.Interfaces;

namespace WinFormsPS5Project.Presentation.ModelServices
{
    public class UserAccount : IUserAccaunt
    {
        public UsersModel User { get; set; }

        public UserAccount()
        {
            User = new UsersModel();
        }
    }
}
