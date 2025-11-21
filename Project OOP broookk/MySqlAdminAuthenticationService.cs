using MySql.Data.MySqlClient;
using System;

namespace Project_OOP_ROMANO.Services
{
    public class MySqlAdminAuthenticationService : IAdminAuthenticationService
    {
        private readonly string _connectionString;

        public MySqlAdminAuthenticationService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool ValidateAdmin(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            using (var myConnection = new MySqlConnection(_connectionString))
            {
                myConnection.Open();

                string query = "SELECT * FROM admin WHERE email = @Email AND password = @Password";
                var cmd = new MySqlCommand(query, myConnection);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                using (var reader = cmd.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }
    }
}
