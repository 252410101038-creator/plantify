namespace Plantify.Views
{
    partial class FormLaporanPenjualan
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
            btnKembali = new Button();
            cmbBulan = new ComboBox();
            cmbTahun = new ComboBox();
            lblJudul = new Label();
            lblTotalPendapatan = new Label();
            lblLaporanPenjualan = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.FromArgb(101, 131, 84);
            btnKembali.FlatStyle = FlatStyle.Flat;
            btnKembali.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(43, 26);
            btnKembali.Margin = new Padding(3, 4, 3, 4);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(113, 34);
            btnKembali.TabIndex = 30;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // cmbBulan
            // 
            cmbBulan.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBulan.ForeColor = Color.FromArgb(101, 131, 84);
            cmbBulan.FormattingEnabled = true;
            cmbBulan.Location = new Point(43, 108);
            cmbBulan.Margin = new Padding(2);
            cmbBulan.Name = "cmbBulan";
            cmbBulan.Size = new Size(114, 26);
            cmbBulan.TabIndex = 31;
            cmbBulan.SelectedIndexChanged += cmbBulan_SelectedIndexChanged;
            // 
            // cmbTahun
            // 
            cmbTahun.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTahun.ForeColor = Color.FromArgb(101, 131, 84);
            cmbTahun.FormattingEnabled = true;
            cmbTahun.Location = new Point(161, 108);
            cmbTahun.Margin = new Padding(2);
            cmbTahun.Name = "cmbTahun";
            cmbTahun.Size = new Size(114, 26);
            cmbTahun.TabIndex = 32;
            cmbTahun.SelectedIndexChanged += cmbTahun_SelectedIndexChanged;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.BackColor = Color.FromArgb(221, 234, 209);
            lblJudul.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.FromArgb(75, 96, 67);
            lblJudul.Location = new Point(38, 66);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(312, 35);
            lblJudul.TabIndex = 33;
            lblJudul.Text = "Laporan Penjualan";
            lblJudul.TextAlign = ContentAlignment.MiddleLeft;
            lblJudul.Click += lblJudul_Click;
            // 
            // lblTotalPendapatan
            // 
            lblTotalPendapatan.AutoSize = true;
            lblTotalPendapatan.BackColor = Color.FromArgb(221, 234, 209);
            lblTotalPendapatan.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPendapatan.ForeColor = Color.FromArgb(75, 96, 67);
            lblTotalPendapatan.Location = new Point(349, 373);
            lblTotalPendapatan.Name = "lblTotalPendapatan";
            lblTotalPendapatan.Size = new Size(0, 35);
            lblTotalPendapatan.TabIndex = 34;
            lblTotalPendapatan.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLaporanPenjualan
            // 
            lblLaporanPenjualan.AutoSize = true;
            lblLaporanPenjualan.BackColor = Color.FromArgb(221, 234, 209);
            lblLaporanPenjualan.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLaporanPenjualan.ForeColor = Color.FromArgb(75, 96, 67);
            lblLaporanPenjualan.Location = new Point(43, 395);
            lblLaporanPenjualan.Name = "lblLaporanPenjualan";
            lblLaporanPenjualan.Size = new Size(397, 35);
            lblLaporanPenjualan.TabIndex = 35;
            lblLaporanPenjualan.Text = "Total  Pendapatan : Rp 0";
            lblLaporanPenjualan.TextAlign = ContentAlignment.MiddleLeft;
            lblLaporanPenjualan.Click += lblLaporanPenjualan_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(43, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 217);
            panel1.TabIndex = 36;
            panel1.Paint += panel1_Paint;
            // 
            // FormLaporanPenjualan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 234, 209);
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(lblLaporanPenjualan);
            Controls.Add(lblTotalPendapatan);
            Controls.Add(lblJudul);
            Controls.Add(cmbTahun);
            Controls.Add(cmbBulan);
            Controls.Add(btnKembali);
            Margin = new Padding(2);
            Name = "FormLaporanPenjualan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLaporanPenjualan";
            Load += FormLaporanPenjualan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKembali;
        private ComboBox cmbBulan;
        private ComboBox cmbTahun;
        private Label lblJudul;
        private Label lblTotalPendapatan;
        private Label lblLaporanPenjualan;
        private Panel panel1;
    }
}