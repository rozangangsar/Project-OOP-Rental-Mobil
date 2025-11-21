using System.Data;

namespace Project_OOP_broookk.Services
{
    public interface IAdminPageService;
    {
        DataTable GetAllMobilData();
        void AddMobil(string merk, uint harga, uint tahun);
        void UpdateMobil(uint id, string merk, uint harga, uint tahun);
        bool DeleteMobil(uint id);
    }
}
