using MySql.Data.MySqlClient;
using System;

namespace Project_OOP_ROMANO.Services
{
    public class MySqlPesananDataService : IPesananDataService
    {
        private readonly string _connectionString;

        public MySqlPesananDataService(string connectionString)
        {
            _connectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(_connectionString);
            conn.Open();
            return conn;
        }

        public bool AddPesanan(string username, string merk, uint totalBiaya, DateTime orderTime)
        {
            using (var conn = GetConnection())
            {
                string query = "INSERT INTO pesanan_data (pesanan_username, pesanan_mobil, pesanan_tagihan, pesanan_tanggal) " +
                               "VALUES (@username, @merk, @tagihan, @tanggal)";

                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@merk", merk);
                cmd.Parameters.AddWithValue("@tagihan", totalBiaya);
                cmd.Parameters.AddWithValue("@tanggal", orderTime.ToString("yyyy-MM-dd HH:mm:ss"));

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
