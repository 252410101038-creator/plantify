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
            lblInfoAwal = new Label();
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
            btnKembali.Location = new Point(54, 32);
            btnKembali.Margin = new Padding(4, 5, 4, 5);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(141, 42);
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
            lblJudul.Location = new Point(47, 82);
            lblJudul.Margin = new Padding(4, 0, 4, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(301, 41);
            lblJudul.TabIndex = 30;
            lblJudul.Text = "Kelola Pesanan";
            lblJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flpPesanan
            // 
            flpPesanan.AutoScroll = true;
            flpPesanan.BackColor = Color.White;
            flpPesanan.Location = new Point(54, 142);
            flpPesanan.Margin = new Padding(4, 5, 4, 5);
            flpPesanan.Name = "flpPesanan";
            flpPesanan.Size = new Size(319, 365);
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
            panelDetail.Location = new Point(381, 142);
            panelDetail.Margin = new Padding(4, 5, 4, 5);
            panelDetail.Name = "panelDetail";
            panelDetail.Size = new Size(566, 365);
            panelDetail.TabIndex = 32;
            // 
            // lblInfoAwal
            // 
            lblInfoAwal.Font = new Font("Georgia", 6.75F, FontStyle.Bold);
            lblInfoAwal.ForeColor = Color.FromArgb(75, 96, 67);
            lblInfoAwal.Location = new Point(1, 2);
            lblInfoAwal.Name = "lblInfoAwal";
            lblInfoAwal.Size = new Size(564, 363);
            lblInfoAwal.TabIndex = 33;
            lblInfoAwal.Text = "Pilih transaksi untuk melihat detail";
            lblInfoAwal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTolak
            // 
            btnTolak.BackColor = Color.FromArgb(101, 131, 84);
            btnTolak.FlatStyle = FlatStyle.Flat;
            btnTolak.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTolak.ForeColor = Color.White;
            btnTolak.Location = new Point(269, 318);
            btnTolak.Margin = new Padding(4, 5, 4, 5);
            btnTolak.Name = "btnTolak";
            btnTolak.Size = new Size(141, 42);
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
            btnTerima.Location = new Point(419, 318);
            btnTerima.Margin = new Padding(4, 5, 4, 5);
            btnTerima.Name = "btnTerima";
            btnTerima.Size = new Size(141, 42);
            btnTerima.TabIndex = 33;
            btnTerima.Text = "Terima";
            btnTerima.UseVisualStyleBackColor = false;
            btnTerima.Click += btnTerima_Click;
            // 
            // lblNoTelepon
            // 
            lblNoTelepon.Font = new Font("Georgia", 7F);
            lblNoTelepon.ForeColor = Color.FromArgb(75, 96, 67);
            lblNoTelepon.Location = new Point(349, 42);
            lblNoTelepon.Name = "lblNoTelepon";
            lblNoTelepon.Size = new Size(214, 32);
            lblNoTelepon.TabIndex = 23;
            lblNoTelepon.Text = "-";
            lblNoTelepon.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAlamat
            // 
            lblAlamat.Font = new Font("Georgia", 7F);
            lblAlamat.ForeColor = Color.FromArgb(75, 96, 67);
            lblAlamat.Location = new Point(349, 72);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(214, 32);
            lblAlamat.TabIndex = 22;
            lblAlamat.Text = "-";
            lblAlamat.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Georgia", 6.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(75, 96, 67);
            label2.Location = new Point(154, 42);
            label2.Name = "label2";
            label2.Size = new Size(159, 32);
            label2.TabIndex = 21;
            label2.Text = "No Telepon";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Georgia", 6.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(75, 96, 67);
            label1.Location = new Point(154, 72);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
            label1.TabIndex = 20;
            label1.Text = "Alamat";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            label15.Font = new Font("Georgia", 6.75F, FontStyle.Bold);
            label15.ForeColor = Color.FromArgb(75, 96, 67);
            label15.Location = new Point(154, 282);
            label15.Name = "label15";
            label15.Size = new Size(159, 32);
            label15.TabIndex = 19;
            label15.Text = "Jumlah";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            label14.Font = new Font("Georgia", 6.75F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(75, 96, 67);
            label14.Location = new Point(154, 252);
            label14.Name = "label14";
            label14.Size = new Size(159, 32);
            label14.TabIndex = 18;
            label14.Text = "Nama Bibit";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.Font = new Font("Georgia", 6.75F, FontStyle.Bold);
            label13.ForeColor = Color.FromArgb(75, 96, 67);
            label13.Location = new Point(154, 222);
            label13.Name = "label13";
            label13.Size = new Size(159, 32);
            label13.TabIndex = 17;
            label13.Text = "Estimasi";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.Font = new Font("Georgia", 6.75F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(75, 96, 67);
            label12.Location = new Point(154, 192);
            label12.Name = "label12";
            label12.Size = new Size(159, 32);
            label12.TabIndex = 16;
            label12.Text = "Total Bayar";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.Font = new Font("Georgia", 6.75F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(75, 96, 67);
            label11.Location = new Point(154, 162);
            label11.Name = "label11";
            label11.Size = new Size(159, 32);
            label11.TabIndex = 15;
            label11.Text = "Status Pesanan";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.Font = new Font("Georgia", 6.75F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(75, 96, 67);
            label10.Location = new Point(154, 132);
            label10.Name = "label10";
            label10.Size = new Size(159, 32);
            label10.TabIndex = 14;
            label10.Text = "Status Pembayaran";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tanggal
            // 
            Tanggal.Font = new Font("Georgia", 6.75F, FontStyle.Bold);
            Tanggal.ForeColor = Color.FromArgb(75, 96, 67);
            Tanggal.Location = new Point(154, 102);
            Tanggal.Name = "Tanggal";
            Tanggal.Size = new Size(159, 32);
            Tanggal.TabIndex = 13;
            Tanggal.Text = "Tanggal";
            Tanggal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Font = new Font("Georgia", 6.75F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(75, 96, 67);
            label8.Location = new Point(154, 12);
            label8.Name = "label8";
            label8.Size = new Size(159, 32);
            label8.TabIndex = 12;
            label8.Text = "Nama Customer";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picBuktiTransfer
            // 
            picBuktiTransfer.Location = new Point(4, 187);
            picBuktiTransfer.Margin = new Padding(4, 5, 4, 5);
            picBuktiTransfer.Name = "picBuktiTransfer";
            picBuktiTransfer.Size = new Size(143, 167);
            picBuktiTransfer.SizeMode = PictureBoxSizeMode.StretchImage;
            picBuktiTransfer.TabIndex = 11;
            picBuktiTransfer.TabStop = false;
            // 
            // picBibit
            // 
            picBibit.Location = new Point(4, 12);
            picBibit.Margin = new Padding(4, 5, 4, 5);
            picBibit.Name = "picBibit";
            picBibit.Size = new Size(143, 167);
            picBibit.SizeMode = PictureBoxSizeMode.StretchImage;
            picBibit.TabIndex = 10;
            picBibit.TabStop = false;
            // 
            // lblEstimasi
            // 
            lblEstimasi.Font = new Font("Georgia", 7F);
            lblEstimasi.ForeColor = Color.FromArgb(75, 96, 67);
            lblEstimasi.Location = new Point(349, 222);
            lblEstimasi.Name = "lblEstimasi";
            lblEstimasi.Size = new Size(214, 32);
            lblEstimasi.TabIndex = 9;
            lblEstimasi.Text = "-";
            lblEstimasi.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalBayar
            // 
            lblTotalBayar.Font = new Font("Georgia", 7F);
            lblTotalBayar.ForeColor = Color.FromArgb(75, 96, 67);
            lblTotalBayar.Location = new Point(349, 192);
            lblTotalBayar.Name = "lblTotalBayar";
            lblTotalBayar.Size = new Size(214, 32);
            lblTotalBayar.TabIndex = 8;
            lblTotalBayar.Text = "-";
            lblTotalBayar.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblStatusPesanan
            // 
            lblStatusPesanan.Font = new Font("Georgia", 7F);
            lblStatusPesanan.ForeColor = Color.FromArgb(75, 96, 67);
            lblStatusPesanan.Location = new Point(349, 162);
            lblStatusPesanan.Name = "lblStatusPesanan";
            lblStatusPesanan.Size = new Size(214, 32);
            lblStatusPesanan.TabIndex = 7;
            lblStatusPesanan.Text = "-";
            lblStatusPesanan.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTanggal
            // 
            lblTanggal.Font = new Font("Georgia", 7F);
            lblTanggal.ForeColor = Color.FromArgb(75, 96, 67);
            lblTanggal.Location = new Point(349, 102);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(214, 32);
            lblTanggal.TabIndex = 6;
            lblTanggal.Text = "-";
            lblTanggal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblStatusPembayaran
            // 
            lblStatusPembayaran.Font = new Font("Georgia", 7F);
            lblStatusPembayaran.ForeColor = Color.FromArgb(75, 96, 67);
            lblStatusPembayaran.Location = new Point(349, 132);
            lblStatusPembayaran.Name = "lblStatusPembayaran";
            lblStatusPembayaran.Size = new Size(214, 32);
            lblStatusPembayaran.TabIndex = 5;
            lblStatusPembayaran.Text = "-";
            lblStatusPembayaran.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNamaCustomer
            // 
            lblNamaCustomer.Font = new Font("Georgia", 7F);
            lblNamaCustomer.ForeColor = Color.FromArgb(75, 96, 67);
            lblNamaCustomer.Location = new Point(349, 12);
            lblNamaCustomer.Name = "lblNamaCustomer";
            lblNamaCustomer.Size = new Size(214, 32);
            lblNamaCustomer.TabIndex = 4;
            lblNamaCustomer.Text = "-";
            lblNamaCustomer.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblJumlah
            // 
            lblJumlah.Font = new Font("Georgia", 7F);
            lblJumlah.ForeColor = Color.FromArgb(75, 96, 67);
            lblJumlah.Location = new Point(349, 282);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(214, 32);
            lblJumlah.TabIndex = 3;
            lblJumlah.Text = "-";
            lblJumlah.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNamaBibit
            // 
            lblNamaBibit.Font = new Font("Georgia", 7F);
            lblNamaBibit.ForeColor = Color.FromArgb(75, 96, 67);
            lblNamaBibit.Location = new Point(349, 252);
            lblNamaBibit.Name = "lblNamaBibit";
            lblNamaBibit.Size = new Size(214, 32);
            lblNamaBibit.TabIndex = 2;
            lblNamaBibit.Text = "-";
            lblNamaBibit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FormKelolaPesanan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 234, 209);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 563);
            ControlBox = false;
            Controls.Add(panelDetail);
            Controls.Add(flpPesanan);
            Controls.Add(lblJudul);
            Controls.Add(btnKembali);
            Margin = new Padding(4, 5, 4, 5);
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