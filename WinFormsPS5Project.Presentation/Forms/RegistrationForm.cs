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
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;
using WinFormsPS5Project.Presentation.ModelServices.Interfaces;

namespace WinFormsPS5Project.Presentation
{
    public partial class RegistrationForm : Form
    {
        private IUserService _userService;
        private IUserAccaunt _user;

        public RegistrationForm(IUserService userService, IUserAccaunt user)
        {
            InitializeComponent();

            _userService = userService;
            _user = user;
        }

        private void _closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _registerBtn_Click(object sender, EventArgs e)
        {
            var login = _loginFIeld.Text;
            var pass = _passwordField.Text;
            var name = _nameField.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show(Constant.EmptyLoginPass, Constant.RegistrationError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if(string.IsNullOrEmpty(name))
            {
                MessageBox.Show(Constant.EmptyNameField, Constant.RegistrationError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var isUserConsistInDb = _userService.IsUserConsistInDB(login);

            if(!isUserConsistInDb)
            {
                var user = new UsersModel()
                {
                    UserLogin = login,
                    Pass = pass,
                    UserName = name
                };

                _userService.Add(user);

                MessageBox.Show(Constant.SuccessfulRegistration, Constant.OK, MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                AutorizationForm autorizationForm = new AutorizationForm(_userService, _user);
                autorizationForm.Show();
            }
            else
            {
                MessageBox.Show(Constant.EmptyNameField, Constant.NotCorrectLogin, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
