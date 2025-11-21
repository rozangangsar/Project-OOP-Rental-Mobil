using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Project_OOP_ROMANO.Services;

namespace Project_OOP_ROMANO
{
    public partial class RegisterPage : Form
    {
        private readonly IRegistrationService _registrationService;

        public RegisterPage(IRegistrationService registrationService = null)
        {
            InitializeComponent();
            _registrationService = registrationService ?? new MySqlRegistrationService("server=127.0.0.1;database=program_akun;uid=userprogram;pwd=user;");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            string getEmail = textBoxEmail.Text;
            string getUsername = textBoxUsername.Text;
            string getPassword = textBoxPassword.Text;

            // Validate input
            if (string.IsNullOrWhiteSpace(getEmail) ||
                string.IsNullOrWhiteSpace(getUsername) ||
                string.IsNullOrWhiteSpace(getPassword))
            {
                MessageBox.Show("Email, Username, dan Password harus diisi.");
                return;
            }

            try
            {
                bool success = _registrationService.RegisterUser(getEmail, getUsername, getPassword);
                if (success)
                {
                    MessageBox.Show("Registrasi berhasil!");
                    using (var form3 = new LoginPage())
                    {
                        this.Hide();
                        form3.ShowDialog();
                    }
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Gagal mendaftarkan akun.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            using (var form1 = new Form1())
            {
                this.Hide();
                form1.ShowDialog();
            }

            Application.Exit();
        }
    }
}
