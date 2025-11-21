using System.Windows.Forms;

namespace Project_OOP_ROMANO
{
    public partial class HomePage : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxNota = new System.Windows.Forms.TextBox();
            this.textBoxTagihan = new System.Windows.Forms.TextBox();
            this.textBoxBookingMobil = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_pesan = new System.Windows.Forms.Button();
            this.TanggalPengembalian = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TanggalRental = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMobil = new System.Windows.Forms.ComboBox();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.textBoxNota);
            this.groupBox2.Controls.Add(this.textBoxTagihan);
            this.groupBox2.Controls.Add(this.textBoxBookingMobil);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(127, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 149);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nota Pemesanan";
            // 
            // textBoxNota
            // 
            this.textBoxNota.Location = new System.Drawing.Point(57, 100);
            this.textBoxNota.Multiline = true;
            this.textBoxNota.Name = "textBoxNota";
            this.textBoxNota.ReadOnly = true;
            this.textBoxNota.Size = new System.Drawing.Size(415, 35);
            this.textBoxNota.TabIndex = 11;
            // 
            // textBoxTagihan
            // 
            this.textBoxTagihan.Location = new System.Drawing.Point(247, 58);
            this.textBoxTagihan.Name = "textBoxTagihan";
            this.textBoxTagihan.Size = new System.Drawing.Size(203, 20);
            this.textBoxTagihan.TabIndex = 9;
            // 
            // textBoxBookingMobil
            // 
            this.textBoxBookingMobil.Location = new System.Drawing.Point(247, 22);
            this.textBoxBookingMobil.Name = "textBoxBookingMobil";
            this.textBoxBookingMobil.Size = new System.Drawing.Size(203, 20);
            this.textBoxBookingMobil.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Tagihan ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tipe Mobil/Tahun Keluaran";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rental Mobil ROMANO";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_pesan);
            this.groupBox1.Controls.Add(this.TanggalPengembalian);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TanggalRental);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxMobil);
            this.groupBox1.Location = new System.Drawing.Point(127, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 176);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Pastikan Pesanan Sudah Sesuai!";
            // 
            // btn_pesan
            // 
            this.btn_pesan.Location = new System.Drawing.Point(217, 144);
            this.btn_pesan.Name = "btn_pesan";
            this.btn_pesan.Size = new System.Drawing.Size(86, 26);
            this.btn_pesan.TabIndex = 6;
            this.btn_pesan.Text = "Pesan";
            this.btn_pesan.UseVisualStyleBackColor = true;
            this.btn_pesan.Click += new System.EventHandler(this.btn_pesan_Click);
            // 
            // TanggalPengembalian
            // 
            this.TanggalPengembalian.Location = new System.Drawing.Point(244, 89);
            this.TanggalPengembalian.Name = "TanggalPengembalian";
            this.TanggalPengembalian.Size = new System.Drawing.Size(204, 20);
            this.TanggalPengembalian.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tanggal Pengembalian";
            // 
            // TanggalRental
            // 
            this.TanggalRental.Location = new System.Drawing.Point(244, 63);
            this.TanggalRental.Name = "TanggalRental";
            this.TanggalRental.Size = new System.Drawing.Size(204, 20);
            this.TanggalRental.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tanggal Rental";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipe Mobil/Tahun Keluaran";
            // 
            // comboBoxMobil
            // 
            this.comboBoxMobil.FormattingEnabled = true;
            this.comboBoxMobil.Location = new System.Drawing.Point(244, 36);
            this.comboBoxMobil.Name = "comboBoxMobil";
            this.comboBoxMobil.Size = new System.Drawing.Size(204, 21);
            this.comboBoxMobil.TabIndex = 0;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(127, 416);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(86, 22);
            this.btn_Logout.TabIndex = 6;
            this.btn_Logout.Text = "Log out";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "HomePage";
            this.Text = "Home Page Pemesanan";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker TanggalPengembalian;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker TanggalRental;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMobil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_pesan;
        private System.Windows.Forms.TextBox textBoxTagihan;
        private System.Windows.Forms.TextBox textBoxBookingMobil;
        private System.Windows.Forms.Button btn_Logout;
        private TextBox textBoxNota;
    }
}