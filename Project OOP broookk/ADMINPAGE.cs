using Project_OOP_ROMANO.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project_OOP_ROMANO
{
    public partial class ADMINPAGE : Form
    {
        private readonly IAdminPageService _adminPageService;

        public ADMINPAGE(IAdminPageService adminMobilService = null)
        {
            InitializeComponent();
            _adminPageService = adminMobilService ?? new MySqlAdminPageService("server=127.0.0.1;database=program_mobil;uid=adminganteng;pwd=gantengbanget;");
        }

        private void btn_tampildata_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable data = _adminPageService.GetAllMobilData();
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data: " + ex.Message);
            }
        }

        private void btn_tambahdata_Click(object sender, EventArgs e)
        {
            try
            {
                string getMerk = textBoxMerk.Text;
                uint getHarga = uint.Parse(textBoxHarga.Text);
                uint getTahun = uint.Parse(textBoxTahun.Text);

                _adminPageService.AddMobil(getMerk, getHarga, getTahun);
                MessageBox.Show("Data berhasil ditambahkan!");

                textBoxMerk.Text = "";
                textBoxHarga.Text = "";
                textBoxTahun.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                uint getMobilID = (uint)NumIDMobil.Value;
                string getMerk = textEditMerk.Text;
                uint getHarga = uint.Parse(textEditHarga.Text);
                uint getTahun = uint.Parse(textEditTahun.Text);

                _adminPageService.UpdateMobil(getMobilID, getMerk, getHarga, getTahun);
                MessageBox.Show("Data berhasil disimpan!");

                textBoxMerk.Text = "";
                textBoxHarga.Text = "";
                textBoxTahun.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                uint getMobilID = (uint)(NumIDMobil2.Value);

                bool deleted = _adminPageService.DeleteMobil(getMobilID);
                if (deleted)
                    MessageBox.Show("Data berhasil dihapus!");
                else
                    MessageBox.Show("Data dengan ID tersebut tidak ditemukan.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
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
