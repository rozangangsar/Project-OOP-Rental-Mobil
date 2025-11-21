using System.Windows.Forms;

namespace Project_OOP_ROMANO
{
    public partial class ADMINPAGE : Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTahun = new System.Windows.Forms.TextBox();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.textBoxMerk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumIDMobil = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.textEditTahun = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textEditHarga = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textEditMerk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.NumIDMobil2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_tampildata = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumIDMobil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumIDMobil2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxTahun);
            this.groupBox1.Controls.Add(this.textBoxHarga);
            this.groupBox1.Controls.Add(this.textBoxMerk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tambah Mobil";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(118, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_tambahdata_Click);
            // 
            // textBoxTahun
            // 
            this.textBoxTahun.Location = new System.Drawing.Point(101, 66);
            this.textBoxTahun.Name = "textBoxTahun";
            this.textBoxTahun.Size = new System.Drawing.Size(190, 20);
            this.textBoxTahun.TabIndex = 5;
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Location = new System.Drawing.Point(101, 45);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(190, 20);
            this.textBoxHarga.TabIndex = 4;
            // 
            // textBoxMerk
            // 
            this.textBoxMerk.Location = new System.Drawing.Point(101, 22);
            this.textBoxMerk.Name = "textBoxMerk";
            this.textBoxMerk.Size = new System.Drawing.Size(190, 20);
            this.textBoxMerk.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tahun Keluaran";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Harga Sewa/Hari";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Merk Mobil";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NumIDMobil);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.textEditTahun);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textEditHarga);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textEditMerk);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 187);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Data Mobil";
            // 
            // NumIDMobil
            // 
            this.NumIDMobil.Location = new System.Drawing.Point(100, 27);
            this.NumIDMobil.Name = "NumIDMobil";
            this.NumIDMobil.Size = new System.Drawing.Size(190, 20);
            this.NumIDMobil.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEdit.Location = new System.Drawing.Point(118, 121);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(65, 35);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // textEditTahun
            // 
            this.textEditTahun.Location = new System.Drawing.Point(100, 95);
            this.textEditTahun.Name = "textEditTahun";
            this.textEditTahun.Size = new System.Drawing.Size(190, 20);
            this.textEditTahun.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Merk Mobil";
            // 
            // textEditHarga
            // 
            this.textEditHarga.Location = new System.Drawing.Point(100, 71);
            this.textEditHarga.Name = "textEditHarga";
            this.textEditHarga.Size = new System.Drawing.Size(190, 20);
            this.textEditHarga.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Harga Sewa/Hari";
            // 
            // textEditMerk
            // 
            this.textEditMerk.Location = new System.Drawing.Point(100, 49);
            this.textEditMerk.Name = "textEditMerk";
            this.textEditMerk.Size = new System.Drawing.Size(190, 20);
            this.textEditMerk.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tahun Keluaran";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Location = new System.Drawing.Point(124, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 35);
            this.button3.TabIndex = 13;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "ID";
            // 
            // NumIDMobil2
            // 
            this.NumIDMobil2.Location = new System.Drawing.Point(100, 27);
            this.NumIDMobil2.Name = "NumIDMobil2";
            this.NumIDMobil2.Size = new System.Drawing.Size(190, 20);
            this.NumIDMobil2.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NumIDMobil2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(6, 353);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 95);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Hapus Data Mobil";
            // 
            // btn_tampildata
            // 
            this.btn_tampildata.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_tampildata.Location = new System.Drawing.Point(324, 387);
            this.btn_tampildata.Name = "btn_tampildata";
            this.btn_tampildata.Size = new System.Drawing.Size(126, 32);
            this.btn_tampildata.TabIndex = 16;
            this.btn_tampildata.Text = "Tampilkan Data";
            this.btn_tampildata.UseVisualStyleBackColor = false;
            this.btn_tampildata.Click += new System.EventHandler(this.btn_tampildata_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(324, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(464, 369);
            this.dataGridView1.TabIndex = 23;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(324, 425);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(86, 22);
            this.btn_Logout.TabIndex = 24;
            this.btn_Logout.Text = "Log out";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // ADMINPAGE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_tampildata);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ADMINPAGE";
            this.Text = "Home Page ADMIN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumIDMobil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumIDMobil2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxTahun;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.TextBox textBoxMerk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox textEditTahun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textEditHarga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textEditMerk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NumIDMobil;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NumIDMobil2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_tampildata;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Button btn_Logout;
    }
}