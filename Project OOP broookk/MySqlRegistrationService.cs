using System;
using MySql.Data.MySqlClient;

namespace Project_OOP_ROMANO.Services
{
    public class MySqlRegistrationService : IRegistrationService
    {
        private readonly string _connectionString;

        public MySqlRegistrationService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool RegisterUser(string email, string username, string password)
        {
            using (var myConnection = new MySqlConnection(_connectionString))
            {
                myConnection.Open();

                string query = "INSERT INTO akun_data(akun_email, akun_nama, akun_password, akun_tgl_buat) " +
                               "VALUES (@Email, @Username, @Password, @Tanggal)";

                using (var cmd = new MySqlCommand(query, myConnection))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Tanggal", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
