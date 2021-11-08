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
using WinFormsPS5Project.Presentation.ModelServices.Interfaces;

namespace WinFormsPS5Project.Presentation
{
    public partial class Menu : Form
    {
        private IUserService _userService;
        private IUserAccaunt _user;

        public Menu(IUserAccaunt user, IUserService userService)
        {
            InitializeComponent();

            _userService = userService;
            _user = user;
            
        }
    }
}
