using System;
using System.Collections.Generic;

namespace Project_OOP_ROMANO.Services
{
    public interface IMobilDataService
    {
        IEnumerable<(string Merk, string Tahun)> GetAllMobilData();
        uint? GetHargaByMerk(string merk);
    }
}
