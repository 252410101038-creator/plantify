namespace plantify.Views
{
    partial class FormDashboardAdmin
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
            btnKelolaKatalog = new Button();
            btnLaporanKeuangan = new Button();
            btnKelolaTransaksi = new Button();
            btnLogout = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnKelolaKatalog
            // 
            btnKelolaKatalog.BackColor = Color.FromArgb(75, 96, 67);
            btnKelolaKatalog.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaKatalog.ForeColor = Color.White;
            btnKelolaKatalog.Location = new Point(64, 283);
            btnKelolaKatalog.Margin = new Padding(4, 3, 4, 3);
            btnKelolaKatalog.Name = "btnKelolaKatalog";
            btnKelolaKatalog.Size = new Size(394, 97);
            btnKelolaKatalog.TabIndex = 0;
            btnKelolaKatalog.Text = "Kelola Katalog";
            btnKelolaKatalog.UseVisualStyleBackColor = false;
            btnKelolaKatalog.Click += btnKelolaKatalog_Click;
            // 
            // btnLaporanKeuangan
            // 
            btnLaporanKeuangan.BackColor = Color.FromArgb(75, 96, 67);
            btnLaporanKeuangan.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLaporanKeuangan.ForeColor = Color.White;
            btnLaporanKeuangan.Location = new Point(541, 283);
            btnLaporanKeuangan.Margin = new Padding(4, 3, 4, 3);
            btnLaporanKeuangan.Name = "btnLaporanKeuangan";
            btnLaporanKeuangan.Size = new Size(394, 97);
            btnLaporanKeuangan.TabIndex = 1;
            btnLaporanKeuangan.Text = "Laporan Keuangan";
            btnLaporanKeuangan.UseVisualStyleBackColor = false;
            btnLaporanKeuangan.Click += btnLaporanKeuangan_Click;
            // 
            // btnKelolaTransaksi
            // 
            btnKelolaTransaksi.BackColor = Color.FromArgb(75, 96, 67);
            btnKelolaTransaksi.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaTransaksi.ForeColor = Color.White;
            btnKelolaTransaksi.Location = new Point(64, 422);
            btnKelolaTransaksi.Margin = new Padding(4, 3, 4, 3);
            btnKelolaTransaksi.Name = "btnKelolaTransaksi";
            btnKelolaTransaksi.Size = new Size(394, 97);
            btnKelolaTransaksi.TabIndex = 2;
            btnKelolaTransaksi.Text = "Kelola Transaksi";
            btnKelolaTransaksi.UseVisualStyleBackColor = false;
            btnKelolaTransaksi.Click += btnKelolaTransaksi_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(75, 96, 67);
            btnLogout.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(541, 422);
            btnLogout.Margin = new Padding(4, 3, 4, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(394, 97);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(75, 96, 67);
            label1.Location = new Point(229, 178);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(588, 51);
            label1.TabIndex = 4;
            label1.Text = "Selamat Datang, Admin!";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Plantify.Properties.Resources.plantify;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(829, 15);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 77);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FormDashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Plantify.Properties.Resources.Photo_from_n;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 563);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(btnKelolaTransaksi);
            Controls.Add(btnLaporanKeuangan);
            Controls.Add(btnKelolaKatalog);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormDashboardAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDashboardAdmin";
            Load += FormDashboardAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKelolaKatalog;
        private Button btnLaporanKeuangan;
        private Button btnKelolaTransaksi;
        private Button btnLogout;
        private Label label1;
        private PictureBox pictureBox1;
    }
}