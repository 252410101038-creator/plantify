namespace Plantify.Views
{
    partial class FormKelolaPesanan
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
            lblJudul = new Label();
            flpPesanan = new FlowLayoutPanel();
            panelDetail = new Panel();
            btnTolak = new Button();
            btnTerima = new Button();
            lblNoTelepon = new Label();
            lblAlamat = new Label();
            label2 = new Label();
            label1 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            Tanggal = new Label();
            label8 = new Label();
            picBuktiTransfer = new PictureBox();
            picBibit = new PictureBox();
            lblEstimasi = new Label();
            lblTotalBayar = new Label();
            lblStatusPesanan = new Label();
            lblTanggal = new Label();
            lblStatusPembayaran = new Label();
            lblNamaCustomer = new Label();
            lblJumlah = new Label();
            lblNamaBibit = new Label();
            lblInfoAwal = new Label();
            panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBuktiTransfer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBibit).BeginInit();
            SuspendLayout();
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.FromArgb(101, 131, 84);
            btnKembali.FlatStyle = FlatStyle.Flat;
            btnKembali.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(38, 19);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(99, 25);
            btnKembali.TabIndex = 29;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.BackColor = Color.FromArgb(221, 234, 209);
            lblJudul.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.FromArgb(75, 96, 67);
            lblJudul.Location = new Point(33, 49);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(203, 29);
            lblJudul.TabIndex = 30;
            lblJudul.Text = "Kelola Pesanan";
            lblJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flpPesanan
            // 
            flpPesanan.AutoScroll = true;
            flpPesanan.BackColor = Color.White;
            flpPesanan.Location = new Point(38, 85);
            flpPesanan.Name = "flpPesanan";
            flpPesanan.Size = new Size(223, 219);
            flpPesanan.TabIndex = 31;
            // 
            // panelDetail
            // 
            panelDetail.BackColor = Color.White;
            panelDetail.Controls.Add(lblInfoAwal);
            panelDetail.Controls.Add(btnTolak);
            panelDetail.Controls.Add(btnTerima);
            panelDetail.Controls.Add(lblNoTelepon);
            panelDetail.Controls.Add(lblAlamat);
            panelDetail.Controls.Add(label2);
            panelDetail.Controls.Add(label1);
            panelDetail.Controls.Add(label15);
            panelDetail.Controls.Add(label14);
            panelDetail.Controls.Add(label13);
            panelDetail.Controls.Add(label12);
            panelDetail.Controls.Add(label11);
            panelDetail.Controls.Add(label10);
            panelDetail.Controls.Add(Tanggal);
            panelDetail.Controls.Add(label8);
            panelDetail.Controls.Add(picBuktiTransfer);
            panelDetail.Controls.Add(picBibit);
            panelDetail.Controls.Add(lblEstimasi);
            panelDetail.Controls.Add(lblTotalBayar);
            panelDetail.Controls.Add(lblStatusPesanan);
            panelDetail.Controls.Add(lblTanggal);
            panelDetail.Controls.Add(lblStatusPembayaran);
            panelDetail.Controls.Add(lblNamaCustomer);
            panelDetail.Controls.Add(lblJumlah);
            panelDetail.Controls.Add(lblNamaBibit);
            panelDetail.Location = new Point(267, 85);
            panelDetail.Name = "panelDetail";
            panelDetail.Size = new Size(396, 219);
            panelDetail.TabIndex = 32;
            // 
            // btnTolak
            // 
            btnTolak.BackColor = Color.FromArgb(101, 131, 84);
            btnTolak.FlatStyle = FlatStyle.Flat;
            btnTolak.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTolak.ForeColor = Color.White;
            btnTolak.Location = new Point(188, 191);
            btnTolak.Name = "btnTolak";
            btnTolak.Size = new Size(99, 25);
            btnTolak.TabIndex = 33;
            btnTolak.Text = "Tolak";
            btnTolak.UseVisualStyleBackColor = false;
            btnTolak.Click += btnTolak_Click;
            // 
            // btnTerima
            // 
            btnTerima.BackColor = Color.FromArgb(101, 131, 84);
            btnTerima.FlatStyle = FlatStyle.Flat;
            btnTerima.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTerima.ForeColor = Color.White;
            btnTerima.Location = new Point(293, 191);
            btnTerima.Name = "btnTerima";
            btnTerima.Size = new Size(99, 25);
            btnTerima.TabIndex = 33;
            btnTerima.Text = "Terima";
            btnTerima.UseVisualStyleBackColor = false;
            btnTerima.Click += btnTerima_Click;
            // 
            // lblNoTelepon
            // 
            lblNoTelepon.Font = new Font("Georgia", 7F);
            lblNoTelepon.ForeColor = Color.FromArgb(75, 96, 67);
            lblNoTelepon.Location = new Point(244, 25);
            lblNoTelepon.Margin = new Padding(2, 0, 2, 0);
            lblNoTelepon.Name = "lblNoTelepon";
            lblNoTelepon.Size = new Size(150, 19);
            lblNoTelepon.TabIndex = 23;
            lblNoTelepon.Text = "-";
            lblNoTelepon.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAlamat
            // 
            lblAlamat.Font = new Font("Georgia", 7F);
            lblAlamat.ForeColor = Color.FromArgb(75, 96, 67);
            lblAlamat.Location = new Point(244, 43);
            lblAlamat.Margin = new Padding(2, 0, 2, 0);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(150, 19);
            lblAlamat.TabIndex = 22;
            lblAlamat.Text = "-";
            lblAlamat.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Georgia", 6.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(75, 96, 67);
            label2.Location = new Point(108, 25);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 19);
            label2.TabIndex = 21;
            label2.Text = "No Telepon";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Georgia", 6.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(75, 96, 67);
            label1.Location = new Point(108, 43);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 19);
            label1.TabIndex = 20;
            label1.Text = "Alamat";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            label15.Font = new Font("Georgia", 6.75F, FontStyle.Bold);
            label15.ForeColor = Color.FromArgb(75, 96, 67);
            label15.Location = new Point(108, 169);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(111, 19);
            label15.TabIndex = 19;
            label15.Text = "Jumlah";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            label14.Font = new Font("Georgia", 6.75F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(75, 96, 67);
            label14.Location = new Point(108, 151);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(111, 19);
            label14.TabIndex = 18;
            label14.Text = "Nama Bibit";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.Font = new Font("Georgia", 6.75F, FontStyle.Bold);
            label13.ForeColor = Color.FromArgb(75, 96, 67);
            label13.Location = new Point(108, 133);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(111, 19);
            label13.TabIndex = 17;
            label13.Text = "Estimasi";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.Font = new Font("Georgia", 6.75F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(75, 96, 67);
            label12.Location = new Point(108, 115);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(111, 19);
            label12.TabIndex = 16;
            label12.Text = "Total Bayar";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.Font = new Font("Georgia", 6.75F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(75, 96, 67);
            label11.Location = new Point(108, 97);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(111, 19);
            label11.TabIndex = 15;
            label11.Text = "Status Pesanan";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.Font = new Font("Georgia", 6.75F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(75, 96, 67);
            label10.Location = new Point(108, 79);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(111, 19);
            label10.TabIndex = 14;
            label10.Text = "Status Pembayaran";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tanggal
            // 
            Tanggal.Font = new Font("Georgia", 6.75F, FontStyle.Bold);
            Tanggal.ForeColor = Color.FromArgb(75, 96, 67);
            Tanggal.Location = new Point(108, 61);
            Tanggal.Margin = new Padding(2, 0, 2, 0);
            Tanggal.Name = "Tanggal";
            Tanggal.Size = new Size(111, 19);
            Tanggal.TabIndex = 13;
            Tanggal.Text = "Tanggal";
            Tanggal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Font = new Font("Georgia", 6.75F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(75, 96, 67);
            label8.Location = new Point(108, 7);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(111, 19);
            label8.TabIndex = 12;
            label8.Text = "Nama Customer";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picBuktiTransfer
            // 
            picBuktiTransfer.Location = new Point(3, 112);
            picBuktiTransfer.Name = "picBuktiTransfer";
            picBuktiTransfer.Size = new Size(100, 100);
            picBuktiTransfer.SizeMode = PictureBoxSizeMode.StretchImage;
            picBuktiTransfer.TabIndex = 11;
            picBuktiTransfer.TabStop = false;
            // 
            // picBibit
            // 
            picBibit.Location = new Point(3, 7);
            picBibit.Name = "picBibit";
            picBibit.Size = new Size(100, 100);
            picBibit.SizeMode = PictureBoxSizeMode.StretchImage;
            picBibit.TabIndex = 10;
            picBibit.TabStop = false;
            // 
            // lblEstimasi
            // 
            lblEstimasi.Font = new Font("Georgia", 7F);
            lblEstimasi.ForeColor = Color.FromArgb(75, 96, 67);
            lblEstimasi.Location = new Point(244, 133);
            lblEstimasi.Margin = new Padding(2, 0, 2, 0);
            lblEstimasi.Name = "lblEstimasi";
            lblEstimasi.Size = new Size(150, 19);
            lblEstimasi.TabIndex = 9;
            lblEstimasi.Text = "-";
            lblEstimasi.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalBayar
            // 
            lblTotalBayar.Font = new Font("Georgia", 7F);
            lblTotalBayar.ForeColor = Color.FromArgb(75, 96, 67);
            lblTotalBayar.Location = new Point(244, 115);
            lblTotalBayar.Margin = new Padding(2, 0, 2, 0);
            lblTotalBayar.Name = "lblTotalBayar";
            lblTotalBayar.Size = new Size(150, 19);
            lblTotalBayar.TabIndex = 8;
            lblTotalBayar.Text = "-";
            lblTotalBayar.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblStatusPesanan
            // 
            lblStatusPesanan.Font = new Font("Georgia", 7F);
            lblStatusPesanan.ForeColor = Color.FromArgb(75, 96, 67);
            lblStatusPesanan.Location = new Point(244, 97);
            lblStatusPesanan.Margin = new Padding(2, 0, 2, 0);
            lblStatusPesanan.Name = "lblStatusPesanan";
            lblStatusPesanan.Size = new Size(150, 19);
            lblStatusPesanan.TabIndex = 7;
            lblStatusPesanan.Text = "-";
            lblStatusPesanan.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTanggal
            // 
            lblTanggal.Font = new Font("Georgia", 7F);
            lblTanggal.ForeColor = Color.FromArgb(75, 96, 67);
            lblTanggal.Location = new Point(244, 61);
            lblTanggal.Margin = new Padding(2, 0, 2, 0);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(150, 19);
            lblTanggal.TabIndex = 6;
            lblTanggal.Text = "-";
            lblTanggal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblStatusPembayaran
            // 
            lblStatusPembayaran.Font = new Font("Georgia", 7F);
            lblStatusPembayaran.ForeColor = Color.FromArgb(75, 96, 67);
            lblStatusPembayaran.Location = new Point(244, 79);
            lblStatusPembayaran.Margin = new Padding(2, 0, 2, 0);
            lblStatusPembayaran.Name = "lblStatusPembayaran";
            lblStatusPembayaran.Size = new Size(150, 19);
            lblStatusPembayaran.TabIndex = 5;
            lblStatusPembayaran.Text = "-";
            lblStatusPembayaran.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNamaCustomer
            // 
            lblNamaCustomer.Font = new Font("Georgia", 7F);
            lblNamaCustomer.ForeColor = Color.FromArgb(75, 96, 67);
            lblNamaCustomer.Location = new Point(244, 7);
            lblNamaCustomer.Margin = new Padding(2, 0, 2, 0);
            lblNamaCustomer.Name = "lblNamaCustomer";
            lblNamaCustomer.Size = new Size(150, 19);
            lblNamaCustomer.TabIndex = 4;
            lblNamaCustomer.Text = "-";
            lblNamaCustomer.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblJumlah
            // 
            lblJumlah.Font = new Font("Georgia", 7F);
            lblJumlah.ForeColor = Color.FromArgb(75, 96, 67);
            lblJumlah.Location = new Point(244, 169);
            lblJumlah.Margin = new Padding(2, 0, 2, 0);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(150, 19);
            lblJumlah.TabIndex = 3;
            lblJumlah.Text = "-";
            lblJumlah.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNamaBibit
            // 
            lblNamaBibit.Font = new Font("Georgia", 7F);
            lblNamaBibit.ForeColor = Color.FromArgb(75, 96, 67);
            lblNamaBibit.Location = new Point(244, 151);
            lblNamaBibit.Margin = new Padding(2, 0, 2, 0);
            lblNamaBibit.Name = "lblNamaBibit";
            lblNamaBibit.Size = new Size(150, 19);
            lblNamaBibit.TabIndex = 2;
            lblNamaBibit.Text = "-";
            lblNamaBibit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblInfoAwal
            // 
            lblInfoAwal.Font = new Font("Georgia", 6.75F, FontStyle.Bold);
            lblInfoAwal.ForeColor = Color.FromArgb(75, 96, 67);
            lblInfoAwal.Location = new Point(1, 1);
            lblInfoAwal.Margin = new Padding(2, 0, 2, 0);
            lblInfoAwal.Name = "lblInfoAwal";
            lblInfoAwal.Size = new Size(395, 218);
            lblInfoAwal.TabIndex = 33;
            lblInfoAwal.Text = "Pilih transaksi untuk melihat detail";
            lblInfoAwal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormKelolaPesanan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 234, 209);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            ControlBox = false;
            Controls.Add(panelDetail);
            Controls.Add(flpPesanan);
            Controls.Add(lblJudul);
            Controls.Add(btnKembali);
            Name = "FormKelolaPesanan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormKelolaPesanan";
            panelDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBuktiTransfer).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBibit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKembali;
        private Label lblJudul;
        private FlowLayoutPanel flpPesanan;
        private Panel panelDetail;
        private Label lblJumlah;
        private Label lblNamaBibit;
        private Label lblEstimasi;
        private Label lblTotalBayar;
        private Label lblStatusPesanan;
        private Label lblTanggal;
        private Label lblStatusPembayaran;
        private Label lblNamaCustomer;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label Tanggal;
        private Label label8;
        private PictureBox picBuktiTransfer;
        private PictureBox picBibit;
        private Label label2;
        private Label label1;
        private Button btnTolak;
        private Button btnTerima;
        private Label lblNoTelepon;
        private Label lblAlamat;
        private Label lblInfoAwal;
    }
}