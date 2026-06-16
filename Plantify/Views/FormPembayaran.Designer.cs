namespace plantify.Views
{
    partial class FormPembayaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPembayaran));
            lblTotalBayar = new Label();
            btnUploadBukti = new Button();
            picBuktiTransfer = new PictureBox();
            btnKonfirmasi = new Button();
            btnKembali = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)picBuktiTransfer).BeginInit();
            SuspendLayout();
            // 
            // lblTotalBayar
            // 
            lblTotalBayar.Font = new Font("Georgia", 9F, FontStyle.Bold);
            lblTotalBayar.ForeColor = Color.FromArgb(75, 96, 67);
            lblTotalBayar.Location = new Point(78, 190);
            lblTotalBayar.Margin = new Padding(2, 0, 2, 0);
            lblTotalBayar.Name = "lblTotalBayar";
            lblTotalBayar.Size = new Size(150, 22);
            lblTotalBayar.TabIndex = 11;
            lblTotalBayar.Text = "Rp 0";
            lblTotalBayar.TextAlign = ContentAlignment.MiddleCenter;
            lblTotalBayar.Click += lblTotalBayar_Click;
            // 
            // btnUploadBukti
            // 
            btnUploadBukti.BackColor = Color.FromArgb(75, 96, 67);
            btnUploadBukti.Font = new Font("Georgia", 9F);
            btnUploadBukti.ForeColor = Color.White;
            btnUploadBukti.Location = new Point(281, 40);
            btnUploadBukti.Margin = new Padding(2, 2, 2, 2);
            btnUploadBukti.Name = "btnUploadBukti";
            btnUploadBukti.Size = new Size(210, 24);
            btnUploadBukti.TabIndex = 12;
            btnUploadBukti.Text = "Upload Bukti Transfer";
            btnUploadBukti.UseVisualStyleBackColor = false;
            btnUploadBukti.Click += btnUploadBukti_Click;
            // 
            // picBuktiTransfer
            // 
            picBuktiTransfer.Location = new Point(286, 89);
            picBuktiTransfer.Margin = new Padding(2, 2, 2, 2);
            picBuktiTransfer.Name = "picBuktiTransfer";
            picBuktiTransfer.Size = new Size(201, 98);
            picBuktiTransfer.SizeMode = PictureBoxSizeMode.StretchImage;
            picBuktiTransfer.TabIndex = 13;
            picBuktiTransfer.TabStop = false;
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.BackColor = Color.FromArgb(75, 96, 67);
            btnKonfirmasi.Enabled = false;
            btnKonfirmasi.Font = new Font("Georgia", 9F);
            btnKonfirmasi.ForeColor = Color.White;
            btnKonfirmasi.Location = new Point(281, 213);
            btnKonfirmasi.Margin = new Padding(2, 2, 2, 2);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(210, 25);
            btnKonfirmasi.TabIndex = 14;
            btnKonfirmasi.Text = "Konfirmasi Pembayaran";
            btnKonfirmasi.UseVisualStyleBackColor = false;
            btnKonfirmasi.Click += btnKonfirmasi_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.FromArgb(75, 96, 67);
            btnKembali.Font = new Font("Georgia", 9F);
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(13, 13);
            btnKembali.Margin = new Padding(2, 2, 2, 2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(86, 23);
            btnKembali.TabIndex = 15;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormPembayaran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(560, 270);
            ControlBox = false;
            Controls.Add(btnKembali);
            Controls.Add(btnKonfirmasi);
            Controls.Add(picBuktiTransfer);
            Controls.Add(btnUploadBukti);
            Controls.Add(lblTotalBayar);
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "FormPembayaran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pembayaran QRIS";
            Load += FormPembayaran_Load;
            ((System.ComponentModel.ISupportInitialize)picBuktiTransfer).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblTotalBayar;
        private Button btnUploadBukti;
        private PictureBox picBuktiTransfer;
        private Button btnKonfirmasi;
        private Button btnKembali;
        private OpenFileDialog openFileDialog1;
    }
}