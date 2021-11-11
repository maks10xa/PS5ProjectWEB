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
    public partial class ContactsForm : Form
    {
        private IMapper _mapper;
        private IUserAccaunt _userAccaunt;
        private IContactRepo _contactRepo;
        private IContactPres _contactPres;
        private IContactService _contactService;
        private PS5ProjContext _pS5ProjContext;
        private IUserService _userService;
        

        public ContactsForm(IUserAccaunt userAccaunt, IUserService userService, IMapper mapper, PS5ProjContext pS5ProjContext)
        {
            InitializeComponent();

            _mapper = mapper;
            _pS5ProjContext = pS5ProjContext;
            _userAccaunt = userAccaunt;
            _userService = userService;
            _contactPres = new ContactPres();
            _contactRepo = new ContactRepo(pS5ProjContext);
            _contactService = new ContactService(pS5ProjContext, _contactRepo, mapper);

            FillFields();
        }

        private void FillFields()
        {
            var admin1 = _contactService.GetAdmin(1);
            var admin2 = _contactService.GetAdmin(2);

            _artemPhoneNumberTextBox.Text = admin1.PhoneNumber;
            _maxPhoneNumberTextBox.Text = admin2.PhoneNumber;
        }

        private void _closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _infoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoForm infoForm = new InfoForm(_userAccaunt, _userService, _mapper, _pS5ProjContext);
            infoForm.Show();
        }

        private void _costsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CostsForm costsForm = new CostsForm(_userAccaunt, _userService, _mapper, _pS5ProjContext);
            costsForm.Show();
        }

        private void _gamesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GamesForm gamesForm = new GamesForm(_userAccaunt, _userService, _mapper, _pS5ProjContext);
            gamesForm.Show();
        }

        private void _profileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menuForm = new Menu(_userAccaunt, _userService, _mapper, _pS5ProjContext);
            menuForm.Show();
        }

    }
}
