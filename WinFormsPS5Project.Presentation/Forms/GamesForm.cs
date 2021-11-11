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
using WinFormsPS5Project.BuisenessLogicLayer.Services;
using WinFormsPS5Project.BuisenessLogicLayer.Services.Interfaces;
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;
using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.Repositories;
using WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces;
using WinFormsPS5Project.Presentation.ModelServices;
using WinFormsPS5Project.Presentation.ModelServices.Interfaces;

namespace WinFormsPS5Project.Presentation
{
    public partial class GamesForm : Form
    {
        private IMapper _mapper;
        private IUserAccaunt _userAccaunt;
        private IGameRepo _gameRepo;
        private IGames _games;
        private IGameService _gameService;
        private IUserService _userService;
        private PS5ProjContext _pS5ProjContext;

        public GamesForm(IUserAccaunt userAccaunt, IUserService userService, IMapper mapper, PS5ProjContext pS5ProjContext)
        {
            InitializeComponent();

            _mapper = mapper;
            _pS5ProjContext = pS5ProjContext;
            _userService = userService;
            _games = new Games();
            _gameRepo = new GameRepo(pS5ProjContext);
            _userAccaunt = userAccaunt;
            _userService = userService;
            _gameService = new GameService(pS5ProjContext, _gameRepo, mapper);

            GetAllGames();
        }

        private void _closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _profileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menuForm = new Menu(_userAccaunt, _userService, _mapper, _pS5ProjContext);
            menuForm.Show();
        }

        private void _costsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CostsForm costsForm = new CostsForm(_userAccaunt, _userService, _mapper, _pS5ProjContext);
            costsForm.Show();
        }

        private void _infoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoForm infoForm = new InfoForm(_userAccaunt, _userService, _mapper, _pS5ProjContext);
            infoForm.Show();
        }

        private void _contactsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactsForm contactsForm = new ContactsForm(_userAccaunt, _userService, _mapper, _pS5ProjContext);
            contactsForm.Show();
        }

        private void _addToFavouriteBtn_Click(object sender, EventArgs e)
        {
            _userService.AddFavoriteGame(_userAccaunt.User, _gameTextBox.Text);

            if(_userAccaunt.User.FavoriteGame != null)
            {
                MessageBox.Show(Constant.AddGameToFavorite, Constant.OK, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Constant.RegistrationError, Constant.RegistrationError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _listGamesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _gameTextBox.Text = _listGamesComboBox.SelectedItem.ToString();

            foreach (var g in _gameService.GetAllGames())
            {
                if (g.GameName == _gameTextBox.Text)
                {
                    if (_genreTextBox.Text == " ")
                    {
                        _genreTextBox.Text = Constant.GamesNullComboBox;
                        this._genreTextBox.ForeColor = System.Drawing.Color.Gray;
                    }
                    if (_releaseDateTextBox.Text == " ")
                    {
                        _releaseDateTextBox.Text = Constant.GamesNullComboBox;
                        this._releaseDateTextBox.ForeColor = System.Drawing.Color.Gray;
                    }
                    else
                    {
                        _genreTextBox.Text = g.GameGenre;
                        _releaseDateTextBox.Text = g.ReleaseDate.ToString();
                    }
                }
            }
        }

        public void GetAllGames()
        {
            _games.Game  = _gameService.GetAllGames();
            
            foreach(var g in _gameService.GetAllGames())
            {
                _listGamesComboBox.Items.Add(g.GameName);
            }    
        }
    }
}
