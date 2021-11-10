﻿using AutoMapper;
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
using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.Repositories;
using WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces;
using WinFormsPS5Project.Presentation.ModelServices;
using WinFormsPS5Project.Presentation.ModelServices.Interfaces;

namespace WinFormsPS5Project.Presentation
{
    public partial class AutorizationForm : Form
    {
        private PS5ProjContext _pS5ProjContext;
        private IMapper _mapper;
        private IUserRepo _user;
        private IUserAccaunt _userAccaunt;
        private IUserService _userService;

        public AutorizationForm()
        {
            InitializeComponent();
            var config = new AutoMapper.MapperConfiguration(c => c.AddProfile(new MapperProfile()));
            _mapper = config.CreateMapper();

            _pS5ProjContext = new PS5ProjContext();
            _userAccaunt = new UserAccount();
            _user = new UserRepo(_pS5ProjContext);
            _userService = new UserService(_pS5ProjContext, _user, _mapper);
        }

        private void _goToRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm(_userAccaunt, _pS5ProjContext, _user, _mapper);
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

            if (string.IsNullOrEmpty(loginUser) || string.IsNullOrEmpty(passUser))
            {
                MessageBox.Show(Constant.EmptyLoginPass, Constant.AuthorizedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var isUserConsistInDb = _userService.IsUserConsistInDB(loginUser);

            if (isUserConsistInDb)
            {
                _userAccaunt.User = _userService.GetUserByLogin(loginUser, passUser);
                this.Hide();
                Menu menuForm = new Menu(_userAccaunt, _mapper, _pS5ProjContext);
                menuForm.Show();
            }
            else
            {
                MessageBox.Show(Constant.NoUsersInDb, Constant.AuthorizedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
