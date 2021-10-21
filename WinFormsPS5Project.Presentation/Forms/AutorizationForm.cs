using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPS5Project.Presentation
{
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void _goToRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
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
            string loginUser = _loginFIeld.Text;
            string passUser = _passwordField.Text;


        }
    }
}
