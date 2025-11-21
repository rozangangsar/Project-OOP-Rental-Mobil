using System;
using System.Windows.Forms;

namespace Project_OOP_ROMANO
{
    public partial class LoginPage : Form
    {
        public static string LoggedInUsername { get; private set; } // Properti untuk menyimpan username

        private readonly IAuthenticationService _authService;

        public LoginPage(IAuthenticationService authService = null)
        {
            InitializeComponent();
            _authService = authService ?? new MySqlAuthenticationService("server=127.0.0.1;database=program_akun;uid=userprogram;pwd=user;");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_authService.ValidateUser(email, password))
            {
                LoggedInUsername = textBoxUsername.Text; // Simpan username di properti static
                this.Hide();
                using (var form4 = new HomePage())
                {
                    form4.ShowDialog();
                }
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Username atau Password salah!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var form1 = new Form1())
            {
                form1.ShowDialog();
            }
            Application.Exit();
        }
    }
    
}
