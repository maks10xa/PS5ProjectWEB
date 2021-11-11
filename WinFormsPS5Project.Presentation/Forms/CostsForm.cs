using AutoMapper;
using System;
using System.Windows.Forms;
using WinFormsPS5Project.BuisenessLogicLayer.Services;
using WinFormsPS5Project.BuisenessLogicLayer.Services.Interfaces;
using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.Repositories;
using WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces;
using WinFormsPS5Project.Presentation.ModelServices;
using WinFormsPS5Project.Presentation.ModelServices.Interfaces;

namespace WinFormsPS5Project.Presentation
{
    public partial class CostsForm : Form
    {
        private IMapper _mapper;
        private IUserAccaunt _userAccaunt;
        private ICostRepo _costRepo;
        private ICostPres _costPres;
        private ICostsService _costsService;
        private PS5ProjContext _pS5ProjContext;
        private IUserService _userService;

        public CostsForm(IUserAccaunt userAccaunt, IUserService userService, IMapper mapper, PS5ProjContext pS5ProjContext)
        {
            InitializeComponent();

            _mapper = mapper;
            _pS5ProjContext = pS5ProjContext;
            _userAccaunt = userAccaunt;
            _userService = userService;
            _costPres = new CostPres();
            _costRepo = new CostRepo(pS5ProjContext);
            _costsService = new CostsService(pS5ProjContext, _costRepo, mapper);

            GetAllCosts();
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

        private void _gamesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GamesForm gamesForm = new GamesForm(_userAccaunt, _userService, _mapper, _pS5ProjContext);
            gamesForm.Show();
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

        public void GetAllCosts()
        {
            _costPres.Cost = _costsService.GetAllCosts();

            foreach (var c in _costsService.GetAllCosts())
            {
                _costsListCheckBox.Items.Add(c.TimePeriod);
            }
        }

        private void _costsListCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var period = _costsListCheckBox.SelectedItem.ToString();

            foreach (var c in _costsService.GetAllCosts())
            {
                if(period == c.TimePeriod)
                {
                    _costTextBox.Text = String.Format("{0:C}", c.Cost1).ToString();
                }
            }
        }
    }
}
