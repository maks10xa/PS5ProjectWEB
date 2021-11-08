using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsPS5Project.BuisenessLogicLayer.Services.Interfaces;
using WinFormsPS5Project.Presentation.ModelServices;
using WinFormsPS5Project.Presentation.ModelServices.Interfaces;

namespace WinFormsPS5Project.Presentation
{
    public partial class AutorizationForm : Form
    {
        private IUserService _userService;
        private IUserAccaunt _user;

        public AutorizationForm(IUserService userService, IUserAccaunt user)
        {
            InitializeComponent();

            _userService = userService;
            _user = user;
        }

        private void _goToRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm(_userService, _user);
            registrationForm.Show();
        }

        private void _closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _closeBtn_MouseEnter(object sender, EventArgs e)
        {
            _closeBtn.BackColor = Color.DarkRed;
        }

        private void _closeBtn_MouseLeave(object sender, EventArgs e)
        {
            _closeBtn.BackColor = Color.Silver;
        }

        private void _logInBtn_Click(object sender, EventArgs e)
        {
            var loginUser = _loginFIeld.Text;
            var passUser = _passwordField.Text;

           // var user = new UserAccount();

            if (string.IsNullOrEmpty(loginUser) || string.IsNullOrEmpty(passUser))
            {
                MessageBox.Show(Constant.EmptyLoginPass, Constant.AuthorizedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var isUserConsistInDb = _userService.IsUserConsistInDB(loginUser);

            if (isUserConsistInDb)
            {
                _user.User = _userService.GetUserByLogin(loginUser, passUser);
                this.Hide();
                Menu menuForm = new Menu(_user, _userService);
                menuForm.Show();
            }
            else
            {
                MessageBox.Show(Constant.NoUsersInDb, Constant.AuthorizedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
