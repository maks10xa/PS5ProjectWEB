using AutoMapper;
using System;
using System.Windows.Forms;
using WinFormsPS5Project.BuisenessLogicLayer.Services;
using WinFormsPS5Project.BuisenessLogicLayer.Services.Interfaces;
using WinFormsPS5Project.Presentation.ModelServices;
using WinFormsPS5Project.Presentation.ModelServices.Interfaces;

namespace WinFormsPS5Project.Presentation
{
    public partial class GamesForm : Form
    {
        private IMapper _mapper;
        private IUserAccaunt _userAccaunt;
        private IGames _games;
        private IGameService _gameService;
        private IUserService _userService;

        public GamesForm(IUserAccaunt userAccaunt, IMapper mapper)
        {
            InitializeComponent();

            _mapper = mapper;
            _userService = new UserService(mapper);
            _games = new Games();
            _userAccaunt = userAccaunt;
            _gameService = new GameService(mapper);

            GetAllGames();
        }

        private void _closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _profileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menuForm = new Menu(_userAccaunt, _mapper);
            menuForm.Show();
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

        private void _addToFavouriteBtn_Click(object sender, EventArgs e)
        {
            if(_userAccaunt.User.FavoriteGame != null)
            {
                MessageBox.Show(Constant.AddGameToFavorite, Constant.OK, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Constant.Error, Constant.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
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
