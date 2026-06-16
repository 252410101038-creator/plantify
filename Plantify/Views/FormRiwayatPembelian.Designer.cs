namespace Plantify.Views
{
    partial class FormRiwayatPembelian
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
            lblJudul = new Label();
            flpRiwayat = new FlowLayoutPanel();
            panelDetail = new Panel();
            lblInfoAwal = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblNamaBibit = new Label();
            lblJumlah = new Label();
            lblTotalBayar = new Label();
            lblEstimasi = new Label();
            lblStatusPesanan = new Label();
            lblStatusPembayaran = new Label();
            lblTanggal = new Label();
            picBibit = new PictureBox();
            btnKembali = new Button();
            panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBibit).BeginInit();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.BackColor = Color.FromArgb(221, 234, 209);
            lblJudul.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.FromArgb(75, 96, 67);
            lblJudul.Location = new Point(31, 48);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(250, 29);
            lblJudul.TabIndex = 29;
            lblJudul.Text = "Riwayat Pembelian";
            lblJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flpRiwayat
            // 
            flpRiwayat.AutoScroll = true;
            flpRiwayat.BackColor = Color.White;
            flpRiwayat.Location = new Point(37, 85);
            flpRiwayat.Name = "flpRiwayat";
            flpRiwayat.Size = new Size(382, 218);
            flpRiwayat.TabIndex = 30;
            // 
            // panelDetail
            // 
            panelDetail.BackColor = Color.White;
            panelDetail.Controls.Add(lblInfoAwal);
            panelDetail.Controls.Add(label1);
            panelDetail.Controls.Add(label2);
            panelDetail.Controls.Add(label3);
            panelDetail.Controls.Add(label4);
            panelDetail.Controls.Add(label5);
            panelDetail.Controls.Add(lblNamaBibit);
            panelDetail.Controls.Add(lblJumlah);
            panelDetail.Controls.Add(lblTotalBayar);
            panelDetail.Controls.Add(lblEstimasi);
            panelDetail.Controls.Add(lblStatusPesanan);
            panelDetail.Controls.Add(lblStatusPembayaran);
            panelDetail.Controls.Add(lblTanggal);
            panelDetail.Controls.Add(picBibit);
            panelDetail.Location = new Point(425, 85);
            panelDetail.Name = "panelDetail";
            panelDetail.Size = new Size(240, 218);
            panelDetail.TabIndex = 31;
            // 
            // lblInfoAwal
            // 
            lblInfoAwal.Font = new Font("Georgia", 6.75F, FontStyle.Bold);
            lblInfoAwal.ForeColor = Color.FromArgb(75, 96, 67);
            lblInfoAwal.Location = new Point(-1, 0);
            lblInfoAwal.Margin = new Padding(2, 0, 2, 0);
            lblInfoAwal.Name = "lblInfoAwal";
            lblInfoAwal.Size = new Size(239, 218);
            lblInfoAwal.TabIndex = 13;
            lblInfoAwal.Text = "Pilih transaksi untuk melihat detail";
            lblInfoAwal.TextAlign = ContentAlignment.MiddleCenter;
            lblInfoAwal.Click += lblInfoAwal_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Georgia", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(75, 96, 67);
            label1.Location = new Point(3, 192);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 19);
            label1.TabIndex = 12;
            label1.Text = "Total Bayar :";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Georgia", 6.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(75, 96, 67);
            label2.Location = new Point(3, 173);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 19);
            label2.TabIndex = 11;
            label2.Text = "Estimasi :";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Georgia", 6.75F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(75, 96, 67);
            label3.Location = new Point(3, 153);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 19);
            label3.TabIndex = 10;
            label3.Text = "Status Pesanan :";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Georgia", 6.75F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(75, 96, 67);
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(3, 133);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(111, 19);
            label4.TabIndex = 9;
            label4.Text = "Status Pembayaran :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Georgia", 6.75F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(75, 96, 67);
            label5.Location = new Point(3, 113);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 19);
            label5.TabIndex = 8;
            label5.Text = "Tanggal :";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNamaBibit
            // 
            lblNamaBibit.Font = new Font("Georgia", 8F, FontStyle.Bold);
            lblNamaBibit.ForeColor = Color.FromArgb(75, 96, 67);
            lblNamaBibit.Location = new Point(108, 69);
            lblNamaBibit.Margin = new Padding(2, 0, 2, 0);
            lblNamaBibit.Name = "lblNamaBibit";
            lblNamaBibit.Size = new Size(130, 19);
            lblNamaBibit.TabIndex = 7;
            lblNamaBibit.Text = "Nama Bibit :";
            lblNamaBibit.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblJumlah
            // 
            lblJumlah.Font = new Font("Georgia", 8F, FontStyle.Bold);
            lblJumlah.ForeColor = Color.FromArgb(75, 96, 67);
            lblJumlah.Location = new Point(108, 88);
            lblJumlah.Margin = new Padding(2, 0, 2, 0);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(130, 19);
            lblJumlah.TabIndex = 6;
            lblJumlah.Text = "Jumlah :";
            lblJumlah.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalBayar
            // 
            lblTotalBayar.Font = new Font("Georgia", 9.75F, FontStyle.Bold);
            lblTotalBayar.ForeColor = Color.FromArgb(75, 96, 67);
            lblTotalBayar.Location = new Point(118, 192);
            lblTotalBayar.Margin = new Padding(2, 0, 2, 0);
            lblTotalBayar.Name = "lblTotalBayar";
            lblTotalBayar.Size = new Size(120, 19);
            lblTotalBayar.TabIndex = 5;
            lblTotalBayar.Text = "-";
            lblTotalBayar.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEstimasi
            // 
            lblEstimasi.Font = new Font("Georgia", 7F);
            lblEstimasi.ForeColor = Color.FromArgb(75, 96, 67);
            lblEstimasi.Location = new Point(118, 173);
            lblEstimasi.Margin = new Padding(2, 0, 2, 0);
            lblEstimasi.Name = "lblEstimasi";
            lblEstimasi.Size = new Size(120, 19);
            lblEstimasi.TabIndex = 4;
            lblEstimasi.Text = "-";
            lblEstimasi.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblStatusPesanan
            // 
            lblStatusPesanan.Font = new Font("Georgia", 7F);
            lblStatusPesanan.ForeColor = Color.FromArgb(75, 96, 67);
            lblStatusPesanan.Location = new Point(118, 153);
            lblStatusPesanan.Margin = new Padding(2, 0, 2, 0);
            lblStatusPesanan.Name = "lblStatusPesanan";
            lblStatusPesanan.Size = new Size(120, 19);
            lblStatusPesanan.TabIndex = 3;
            lblStatusPesanan.Text = "-";
            lblStatusPesanan.TextAlign = ContentAlignment.MiddleRight;
            lblStatusPesanan.Click += label2_Click;
            // 
            // lblStatusPembayaran
            // 
            lblStatusPembayaran.Font = new Font("Georgia", 7F);
            lblStatusPembayaran.ForeColor = Color.FromArgb(75, 96, 67);
            lblStatusPembayaran.Location = new Point(118, 133);
            lblStatusPembayaran.Margin = new Padding(2, 0, 2, 0);
            lblStatusPembayaran.Name = "lblStatusPembayaran";
            lblStatusPembayaran.Size = new Size(120, 19);
            lblStatusPembayaran.TabIndex = 2;
            lblStatusPembayaran.Text = "-";
            lblStatusPembayaran.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTanggal
            // 
            lblTanggal.Font = new Font("Georgia", 7F);
            lblTanggal.ForeColor = Color.FromArgb(75, 96, 67);
            lblTanggal.Location = new Point(118, 113);
            lblTanggal.Margin = new Padding(2, 0, 2, 0);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(120, 19);
            lblTanggal.TabIndex = 1;
            lblTanggal.Text = "-";
            lblTanggal.TextAlign = ContentAlignment.MiddleRight;
            lblTanggal.Click += lblNamaBibit_Click;
            // 
            // picBibit
            // 
            picBibit.Location = new Point(3, 3);
            picBibit.Name = "picBibit";
            picBibit.Size = new Size(100, 100);
            picBibit.SizeMode = PictureBoxSizeMode.StretchImage;
            picBibit.TabIndex = 0;
            picBibit.TabStop = false;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.FromArgb(101, 131, 84);
            btnKembali.FlatStyle = FlatStyle.Flat;
            btnKembali.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(37, 18);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(99, 25);
            btnKembali.TabIndex = 28;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // FormRiwayatPembelian
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 234, 209);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            ControlBox = false;
            Controls.Add(panelDetail);
            Controls.Add(flpRiwayat);
            Controls.Add(lblJudul);
            Controls.Add(btnKembali);
            Name = "FormRiwayatPembelian";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRiwayatPembelian";
            Load += FormRiwayatPembelian_Load;
            panelDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBibit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblJudul;
        private FlowLayoutPanel flpRiwayat;
        private Panel panelDetail;
        private PictureBox picBibit;
        private Label lblTanggal;
        private Label lblNamaBibit;
        private Label lblJumlah;
        private Label lblTotalBayar;
        private Label lblEstimasi;
        private Label lblStatusPesanan;
        private Label lblStatusPembayaran;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblInfoAwal;
        private Button btnKembali;
    }
}