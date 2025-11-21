using System;

namespace Project_OOP_ROMANO.Services
{
    public interface IPesananDataService
    {
        bool AddPesanan(string username, string merk, uint totalBiaya, DateTime orderTime);
    }
}
