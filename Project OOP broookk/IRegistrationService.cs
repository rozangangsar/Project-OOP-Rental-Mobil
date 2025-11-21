namespace Project_OOP_ROMANO.Services
{
    public interface IRegistrationService
    {
        bool RegisterUser(string email, string username, string password);
    }
}