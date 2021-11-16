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
using WinFormsPS5Project.BuisenessLogicLayer.ViewModels;
using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces;
using WinFormsPS5Project.Presentation.ModelServices;
using WinFormsPS5Project.Presentation.ModelServices.Interfaces;

namespace WinFormsPS5Project.Presentation
{
    public partial class RegistrationForm : Form
    {
        private IMapper _mapper;

        public RegistrationForm(IMapper mapper)
        {
            InitializeComponent();

            _mapper = mapper;
        }

        private void _closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _registerBtn_Click(object sender, EventArgs e)
        {
            var userService = new UserService(_mapper);

            var login = _loginFIeld.Text;
            var pass = _passwordField.Text;
            var name = _nameField.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show(Constant.EmptyLoginPass, Constant.RegistrationError, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            else if(string.IsNullOrEmpty(name))
            {
                MessageBox.Show(Constant.EmptyNameField, Constant.RegistrationError, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            var isUserConsistInDb = userService.IsUserConsistInDB(login);

            if(!isUserConsistInDb)
            {
                var user = new UsersModel()
                {
                    UserLogin = login,
                    Pass = pass,
                    UserName = name,
                    FavoriteGame = null
                };

                userService.Add(user);

                MessageBox.Show(Constant.SuccessfulRegistration, Constant.OK, MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                AutorizationForm autorizationForm = new AutorizationForm();
                autorizationForm.Show();
            }
            else
            {
                MessageBox.Show(Constant.EmptyNameField, Constant.NotCorrectLogin, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }
    }
}
