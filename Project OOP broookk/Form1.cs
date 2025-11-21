using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_OOP_ROMANO.Services;

namespace Project_OOP_ROMANO
{
    public partial class Form1 : Form
    {
        private readonly INavigationService _navigationService;

        public Form1(INavigationService navigationService = null)
        {
            InitializeComponent();
            _navigationService = navigationService ?? new NavigationService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            _navigationService.ShowRegisterPage();
            _navigationService.ExitApplication();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            _navigationService.ShowLoginPage();
            _navigationService.ExitApplication();
        }

        private void btnADMIN_Click(object sender, EventArgs e)
        {
            this.Hide();
            _navigationService.ShowAdminLoginPage();
            _navigationService.ExitApplication();
        }
    }
}
