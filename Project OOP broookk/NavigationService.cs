using System.Windows.Forms;

namespace Project_OOP_ROMANO.Services
{
    public class NavigationService : INavigationService
    {
        public void ShowRegisterPage()
        {
            using (var RP = new RegisterPage())
            {
                RP.ShowDialog();
            }
        }

        public void ShowLoginPage()
        {
            using (var LP = new LoginPage())
            {
                LP.ShowDialog();
            }
        }

        public void ShowAdminLoginPage()
        {
            using (var LA = new LoginAdmin())
            {
                LA.ShowDialog();
            }
        }

        public void ExitApplication()
        {
            Application.Exit();
        }
    }
}
