using Project_OOP_ROMANO.Services;
using System;
using System.Windows.Forms;

namespace Project_OOP_ROMANO
{
    public partial class LoginAdmin : Form
    {
        private readonly IAdminAuthenticationService _authService;

        public LoginAdmin(IAdminAuthenticationService authService = null)
        {
            InitializeComponent();
            _authService = authService ?? new MySqlAdminAuthenticationService("server=127.0.0.1;database=admin;uid=adminganteng;pwd=gantengbanget;");
        }

        private void btnLogin_Click(object sender, EventArgs e)

        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            // Validate inputs before calling the service
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Email dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isValid = false;
            try
            {
                isValid = _authService.ValidateAdmin(email, password);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (isValid)
            {
                using (var adminPage = new ADMINPAGE())
                {
                    this.Hide();
                    adminPage.ShowDialog();
                }

                // Application.Exit can cause issues in testing. Consider removing it during tests
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Email atau Password salah!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
