namespace plantify.Views
{
    partial class FormKatalog
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
            lblSambutan = new Label();
            txtCari = new TextBox();
            btnCari = new Button();
            lblKategori = new Label();
            pictureBox1 = new PictureBox();
            flpKatalog = new FlowLayoutPanel();
            pnlDetail = new Panel();
            lblDeskripsi = new Label();
            lblNamaProduk = new Label();
            pbDetail = new PictureBox();
            btnKembali = new Button();
            btnBeli = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDetail).BeginInit();
            SuspendLayout();
            // 
            // lblSambutan
            // 
            lblSambutan.AutoSize = true;
            lblSambutan.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSambutan.ForeColor = Color.FromArgb(75, 96, 67);
            lblSambutan.Location = new Point(59, 34);
            lblSambutan.Name = "lblSambutan";
            lblSambutan.Size = new Size(213, 29);
            lblSambutan.TabIndex = 0;
            lblSambutan.Text = "Selamat datang!";
            // 
            // txtCari
            // 
            txtCari.Location = new Point(479, 62);
            txtCari.Margin = new Padding(3, 2, 3, 2);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(138, 23);
            txtCari.TabIndex = 1;
            txtCari.TextChanged += txtCari_TextChanged;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.FromArgb(75, 96, 67);
            btnCari.FlatStyle = FlatStyle.Popup;
            btnCari.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(621, 62);
            btnCari.Margin = new Padding(3, 2, 3, 2);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(60, 20);
            btnCari.TabIndex = 2;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += btnCari_Click_1;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKategori.ForeColor = Color.FromArgb(75, 96, 67);
            lblKategori.Location = new Point(475, 43);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(128, 15);
            lblKategori.TabIndex = 8;
            lblKategori.Text = "Cari Bibit dan Kategori:";
            lblKategori.Click += lblKategori_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Plantify.Properties.Resources.a7e06774_5e62_4ee1_a088_40968eabf182;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(48, -4);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 46);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // flpKatalog
            // 
            flpKatalog.AutoScroll = true;
            flpKatalog.Location = new Point(24, 88);
            flpKatalog.Margin = new Padding(3, 2, 3, 2);
            flpKatalog.Name = "flpKatalog";
            flpKatalog.Size = new Size(419, 240);
            flpKatalog.TabIndex = 11;
            // 
            // pnlDetail
            // 
            pnlDetail.BackColor = Color.White;
            pnlDetail.BorderStyle = BorderStyle.FixedSingle;
            pnlDetail.Controls.Add(lblDeskripsi);
            pnlDetail.Controls.Add(lblNamaProduk);
            pnlDetail.Controls.Add(pbDetail);
            pnlDetail.Location = new Point(480, 88);
            pnlDetail.Margin = new Padding(3, 2, 3, 2);
            pnlDetail.Name = "pnlDetail";
            pnlDetail.Size = new Size(202, 240);
            pnlDetail.TabIndex = 12;
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.ForeColor = Color.FromArgb(75, 96, 67);
            lblDeskripsi.Location = new Point(9, 137);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(185, 62);
            lblDeskripsi.TabIndex = 2;
            lblDeskripsi.Text = "Pilih bibit untuk melihat detail";
            // 
            // lblNamaProduk
            // 
            lblNamaProduk.AutoSize = true;
            lblNamaProduk.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaProduk.ForeColor = Color.FromArgb(75, 96, 67);
            lblNamaProduk.Location = new Point(10, 118);
            lblNamaProduk.Name = "lblNamaProduk";
            lblNamaProduk.Size = new Size(68, 15);
            lblNamaProduk.TabIndex = 1;
            lblNamaProduk.Text = "Nama Bibit";
            lblNamaProduk.Click += lblNamaProduk_Click;
            // 
            // pbDetail
            // 
            pbDetail.BackgroundImageLayout = ImageLayout.Stretch;
            pbDetail.Location = new Point(10, 12);
            pbDetail.Margin = new Padding(3, 2, 3, 2);
            pbDetail.Name = "pbDetail";
            pbDetail.Size = new Size(183, 100);
            pbDetail.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDetail.TabIndex = 0;
            pbDetail.TabStop = false;
            pbDetail.Click += pbDetail_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.FromArgb(75, 96, 67);
            btnKembali.FlatStyle = FlatStyle.Popup;
            btnKembali.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(599, 15);
            btnKembali.Margin = new Padding(3, 2, 3, 2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(82, 22);
            btnKembali.TabIndex = 13;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // btnBeli
            // 
            btnBeli.BackColor = Color.FromArgb(75, 96, 67);
            btnBeli.FlatStyle = FlatStyle.Flat;
            btnBeli.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBeli.ForeColor = Color.White;
            btnBeli.Location = new Point(360, 62);
            btnBeli.Margin = new Padding(3, 2, 3, 2);
            btnBeli.Name = "btnBeli";
            btnBeli.Size = new Size(82, 22);
            btnBeli.TabIndex = 0;
            btnBeli.Text = "Beli";
            btnBeli.UseVisualStyleBackColor = false;
            btnBeli.Click += btnBeli_Click;
            // 
            // FormKatalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 234, 209);
            ClientSize = new Size(700, 338);
            ControlBox = false;
            Controls.Add(btnBeli);
            Controls.Add(btnKembali);
            Controls.Add(pnlDetail);
            Controls.Add(flpKatalog);
            Controls.Add(lblKategori);
            Controls.Add(btnCari);
            Controls.Add(txtCari);
            Controls.Add(lblSambutan);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormKatalog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormKatalog";
            Load += FormKatalog_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlDetail.ResumeLayout(false);
            pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSambutan;
        private TextBox txtCari;
        private Button btnCari;
        private Label lblKategori;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flpKatalog;
        private Panel pnlDetail;
        private PictureBox pbDetail;
        private Label lblDeskripsi;
        private Label lblNamaProduk;
        private Button btnKembali;
        private Button btnBeli;
    }
}