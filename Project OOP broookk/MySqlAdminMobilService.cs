using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Project_OOP_broookk.Services
{
    public class MySqlAdminPageService : IAdminPageService
    {
        private readonly string _connectionString;

        public MySqlAdminPageService(string connectionString)
        {
            _connectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(_connectionString);
            conn.Open();
            return conn;
        }

        public DataTable GetAllMobilData()
        {
            using (var conn = GetConnection())
            {
                string query = "SELECT * FROM mobil_data";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public void AddMobil(string merk, uint harga, uint tahun)
        {
            using (var conn = GetConnection())
            {
                string query = "INSERT INTO mobil_data(mobil_merk, mobil_harga, mobil_tahun) VALUES (@merk, @harga, @tahun)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@merk", merk);
                cmd.Parameters.AddWithValue("@harga", harga);
                cmd.Parameters.AddWithValue("@tahun", tahun);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateMobil(uint id, string merk, uint harga, uint tahun)
        {
            using (var conn = GetConnection())
            {
                string query = "UPDATE mobil_data SET mobil_merk=@merk, mobil_harga=@harga, mobil_tahun=@tahun WHERE mobil_id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@merk", merk);
                cmd.Parameters.AddWithValue("@harga", harga);
                cmd.Parameters.AddWithValue("@tahun", tahun);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public bool DeleteMobil(uint id)
        {
            using (var conn = GetConnection())
            {
                string query = "DELETE FROM mobil_data WHERE mobil_id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
