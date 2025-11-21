using System;

namespace RentalCalculatorLibrary
{
    public class RentalCalculator
    {
        public static uint CalculateTotalCost(DateTime tanggalAmbil, DateTime tanggalKembali, uint hargaMobil)
        {
            int jumlahHari = (tanggalKembali - tanggalAmbil).Days;

            if (jumlahHari <= 0)
            {
                throw new ArgumentException("Menyewa mobil minimal 1 hari.");
            }

            uint totalBiaya = (uint)jumlahHari * hargaMobil;
            return totalBiaya;
        }
    }
}

