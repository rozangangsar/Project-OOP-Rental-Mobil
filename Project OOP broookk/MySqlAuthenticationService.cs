using MySql.Data.MySqlClient;

public class MySqlAuthenticationService : IAuthenticationService
{
    private readonly string _connectionString;

    public MySqlAuthenticationService(string connectionString)
    {
        _connectionString = connectionString;
    }

    public bool ValidateUser(string username, string password)
    {
        using (var myConnection = new MySqlConnection(_connectionString))
        {
            myConnection.Open();
            string query = "SELECT * FROM akun_data WHERE akun_nama = @Username AND akun_password = @Password";
            var cmd = new MySqlCommand(query, myConnection);

            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);

            using (var reader = cmd.ExecuteReader())
            {
                return reader.HasRows;
            }
        }
    }
}
