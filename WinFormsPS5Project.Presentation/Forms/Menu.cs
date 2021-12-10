using AutoMapper;
using System;
using System.Windows.Forms;
using WinFormsPS5Project.BuisenessLogicLayer.Services;
using WinFormsPS5Project.BuisenessLogicLayer.Services.Interfaces;
using WinFormsPS5Project.Presentation.ModelServices.Interfaces;

namespace WinFormsPS5Project.Presentation
{
    public partial class Menu : Form
    {
        private IUserAccaunt _userAccaunt;
        private IMapper _mapper;
        private IUserService _userService;

        public Menu(IUserAccaunt userAccaunt, IMapper mapper)
        {
            InitializeComponent();

            _mapper = mapper;
            _userAccaunt = userAccaunt;
            _userService = new UserService(mapper);
            _nameTxt.Text = userAccaunt.User.UserName;
            _loginTxt.Text = userAccaunt.User.UserLogin;

            GetFavoriteGame();
            GetAdminsList();
        }

        private void _gamesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GamesForm gamesForm = new GamesForm(_userAccaunt, _mapper);
            gamesForm.Show();
        }

        private void _costsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CostsForm costsForm = new CostsForm(_userAccaunt, _mapper);
            costsForm.Show();
        }

        private void _infoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoForm infoForm = new InfoForm(_userAccaunt, _mapper);
            infoForm.Show();
        }

        private void _contactsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactsForm contactsForm = new ContactsForm(_userAccaunt, _mapper);
            contactsForm.Show();
        }

        private void _closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void GetFavoriteGame()
        {
            _userAccaunt.User = _userService.GetUserByLogin(_userAccaunt.User.UserLogin);
            
            _gamesListTxt.Text = Constant.FavoriteGame + _userAccaunt.User.FavoriteGame;
        }

        public void GetAdminsList()
        {
            if(_userService.DoesUserIsAdmin(_userAccaunt.User.UserLogin))
            {
                _storedProcedureListOfAdmins.Visible = true;
            }


        }
    }
}
