using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Project_OOP_ROMANO.Services
{
    public class MySqlMobilDataService : IMobilDataService
    {
        private readonly string _connectionString;

        public MySqlMobilDataService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<(string Merk, string Tahun)> GetAllMobilData()
        {
            var list = new List<(string Merk, string Tahun)>();

            using (var myConnection = new MySqlConnection(_connectionString))
            {
                myConnection.Open();
                string query = "SELECT mobil_merk, mobil_tahun FROM mobil_data";
                MySqlCommand cmd = new MySqlCommand(query, myConnection);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string merk = reader["mobil_merk"].ToString();
                        string tahun = reader["mobil_tahun"].ToString();
                        list.Add((merk, tahun));
                    }
                }
            }
            return list;
        }

        public uint? GetHargaByMerk(string merk)
        {
            using (var myConnection = new MySqlConnection(_connectionString))
            {
                myConnection.Open();
                string query = "SELECT mobil_harga FROM mobil_data WHERE mobil_merk = @merk";
                MySqlCommand cmd = new MySqlCommand(query, myConnection);
                cmd.Parameters.AddWithValue("@merk", merk);

                object result = cmd.ExecuteScalar();
                if (result != null && uint.TryParse(result.ToString(), out uint harga))
                {
                    return harga;
                }
                return null;
            }
        }
    }
}
