using AutoMapper;
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
using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces;
using WinFormsPS5Project.Presentation.ModelServices.Interfaces;

namespace WinFormsPS5Project.Presentation
{
    public partial class InfoForm : Form
    {
        private IMapper _mapper;
        private PS5ProjContext _pS5ProjContext;
        private IUserAccaunt _userAccaunt;

        public InfoForm(IUserAccaunt userAccaunt, IMapper mapper, PS5ProjContext pS5ProjContext)
        {
            InitializeComponent();

            _mapper = mapper;
            _pS5ProjContext = pS5ProjContext;
            _userAccaunt = userAccaunt;

            _infoTextBox.Text = Constant.InfoText;  
        }

        private void _profileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menuForm = new Menu(_userAccaunt, _mapper, _pS5ProjContext);
            menuForm.Show();
        }

        private void _gamesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GamesForm gamesForm = new GamesForm(_userAccaunt, _mapper, _pS5ProjContext);
            gamesForm.Show();
        }

        private void _costsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CostsForm costsForm = new CostsForm(_userAccaunt, _mapper, _pS5ProjContext);
            costsForm.Show();
        }

        private void _contactsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactsForm contactsForm = new ContactsForm(_userAccaunt, _mapper, _pS5ProjContext);
            contactsForm.Show();
        }

        private void _closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
