using AutoMapper;
using System;
using System.Windows.Forms;
using WinFormsPS5Project.BuisenessLogicLayer.Services;
using WinFormsPS5Project.BuisenessLogicLayer.Services.Interfaces;
using WinFormsPS5Project.Presentation.ModelServices;
using WinFormsPS5Project.Presentation.ModelServices.Interfaces;

namespace WinFormsPS5Project.Presentation
{
    public partial class ContactsForm : Form
    {
        private IMapper _mapper;
        private IUserAccaunt _userAccaunt;
        private IContactPres _contactPres;
        private IContactService _contactService;
        

        public ContactsForm(IUserAccaunt userAccaunt, IMapper mapper)
        {
            InitializeComponent();

            _mapper = mapper;
            _userAccaunt = userAccaunt;
            _contactPres = new ContactPres();
            _contactService = new ContactService(mapper);

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
            InfoForm infoForm = new InfoForm(_userAccaunt, _mapper);
            infoForm.Show();
        }

        private void _costsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CostsForm costsForm = new CostsForm(_userAccaunt, _mapper);
            costsForm.Show();
        }

        private void _gamesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GamesForm gamesForm = new GamesForm(_userAccaunt, _mapper);
            gamesForm.Show();
        }

        private void _profileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menuForm = new Menu(_userAccaunt, _mapper);
            menuForm.Show();
        }

    }
}
