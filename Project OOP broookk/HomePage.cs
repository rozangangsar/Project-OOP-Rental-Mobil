using Project_OOP_ROMANO.Services;
using RentalCalculatorLibrary;
using System;
using System.Windows.Forms;

namespace Project_OOP_ROMANO
{
    public partial class HomePage : Form
    {
        private readonly IMobilDataService _mobilDataService;
        private readonly IPesananDataService _pesananDataService;

        public HomePage(IMobilDataService mobilDataService = null, IPesananDataService pesananDataService = null)
        {
            InitializeComponent();

            // Default implementations
            _mobilDataService = mobilDataService ??
                new MySqlMobilDataService("server=127.0.0.1;database=program_mobil;uid=adminganteng;pwd=gantengbanget;");

            _pesananDataService = pesananDataService ??
                new MySqlPesananDataService("server=127.0.0.1;database=program_pesanan;uid=adminganteng;pwd=gantengbanget;");
        }

        private void LoadDatatoForm()
        {
            try
            {
                var data = _mobilDataService.GetAllMobilData();
                comboBoxMobil.Items.Clear();
                foreach (var item in data)
                {
                    string displayText = $"{item.Merk}/{item.Tahun}";
                    comboBoxMobil.Items.Add(displayText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            LoadDatatoForm();
        }

        private void btn_pesan_Click(object sender, EventArgs e)
        {
            if (comboBoxMobil.SelectedIndex == -1)
            {
                MessageBox.Show("Silakan pilih mobil terlebih dahulu.");
                return;
            }

            string selectedItem = comboBoxMobil.SelectedItem.ToString();
            string selectedMerk = selectedItem.Split('/')[0].Trim();

            uint? hargaMobil = null;
            try
            {
                hargaMobil = _mobilDataService.GetHargaByMerk(selectedMerk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memproses data: " + ex.Message);
                return;
            }

            if (!hargaMobil.HasValue)
            {
                MessageBox.Show("Gagal menemukan data harga mobil.");
                return;
            }

            // Ambil tanggal awal rental dan tanggal pengembalian
            DateTime tanggalAmbil = TanggalRental.Value;
            DateTime tanggalKembali = TanggalPengembalian.Value;

            // Hitung jumlah hari
            uint totalBiaya = RentalCalculator.CalculateTotalCost(tanggalAmbil, tanggalKembali, hargaMobil);

            // Tampilkan hasil ke TextBox
            textBoxTagihan.Text = $"Rp{totalBiaya:N0}";
            textBoxBookingMobil.Text = selectedItem;

            // Simpan pesanan ke database pesanan melalui service
            string getUsername = LoginPage.LoggedInUsername;
            DateTime orderTime = DateTime.Now;

            try
            {
                bool success = _pesananDataService.AddPesanan(getUsername, selectedMerk, totalBiaya, orderTime);

                if (success)
                {
                    MessageBox.Show("Pesanan berhasil disimpan!");
                    textBoxNota.Text = $"Terimakasih {getUsername} telah menyewa mobil {selectedMerk}. " +
                                       $"Jika Anda telah selesai memesan, Anda dapat Logout. Semoga anda puas!";
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan pesanan.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            using (var form1 = new Form1())
            {
                this.Hide();
                form1.ShowDialog();
            }

            Application.Exit();
        }
    }
}
