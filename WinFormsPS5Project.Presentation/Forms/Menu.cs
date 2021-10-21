using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsPS5Project.DataAccessLayer.Models;

namespace WinFormsPS5Project.Presentation
{
    public partial class Menu : Form
    {
        PS5ProjContext db = new PS5ProjContext();
        public Menu()
        {
            InitializeComponent();
        }
    }
}
