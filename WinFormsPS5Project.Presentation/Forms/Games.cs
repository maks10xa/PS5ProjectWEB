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
using WinFormsPS5Project.DataAccessLayer.Repositories;
using WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces;
using WinFormsPS5Project.Presentation.ModelServices.Interfaces;

namespace WinFormsPS5Project.Presentation
{
    public partial class Games : Form
    {
        private IUserAccaunt _userAccaunt;
        private IGameRepo _gameRepo;
        private IGames _games;

        public Games(IUserAccaunt userAccaunt)
        {
            InitializeComponent();

            _games = new Games();
            _userAccaunt = userAccaunt;

            var a = _gameRepo.GetAllGames();
            _listGamesComboBox.Items.Add(a); 
        }

        private void _closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _profileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menuForm = new Menu(_userAccaunt);
            menuForm.Show();
        }

        private void _costsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CostsForm costsForm = new CostsForm(_userAccaunt);
            costsForm.Show();
        }

        private void _infoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoForm infoForm = new InfoForm(_userAccaunt);
            infoForm.Show();
        }

        private void _contactsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactsForm contactsForm = new ContactsForm(_userAccaunt);
            contactsForm.Show();
        }

        private void _addToFavouriteBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void _listGamesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var game = _listGamesComboBox.SelectedItem;
        }
    }
}
