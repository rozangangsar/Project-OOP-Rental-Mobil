namespace Project_OOP_ROMANO.Services
{
    public interface IAdminAuthenticationService
    {
        bool ValidateAdmin(string email, string password);
    }
}
