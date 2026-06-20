namespace plantify.Views
{
    partial class UcRiwayat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblIdTransaksi = new Label();
            lblNamaBibit = new Label();
            lblStatusPesanan = new Label();
            lblTotalBayar = new Label();
            SuspendLayout();
            // 
            // lblIdTransaksi
            // 
            lblIdTransaksi.AccessibleRole = AccessibleRole.PageTab;
            lblIdTransaksi.Font = new Font("Georgia", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdTransaksi.ForeColor = Color.FromArgb(75, 96, 67);
            lblIdTransaksi.Location = new Point(3, 6);
            lblIdTransaksi.Name = "lblIdTransaksi";
            lblIdTransaksi.Size = new Size(37, 30);
            lblIdTransaksi.TabIndex = 0;
            lblIdTransaksi.Text = "001";
            lblIdTransaksi.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNamaBibit
            // 
            lblNamaBibit.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblNamaBibit.ForeColor = Color.FromArgb(75, 96, 67);
            lblNamaBibit.Location = new Point(47, 6);
            lblNamaBibit.Name = "lblNamaBibit";
            lblNamaBibit.Size = new Size(127, 30);
            lblNamaBibit.TabIndex = 1;
            lblNamaBibit.Text = "Bibit Tomat";
            lblNamaBibit.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStatusPesanan
            // 
            lblStatusPesanan.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblStatusPesanan.ForeColor = Color.FromArgb(75, 96, 67);
            lblStatusPesanan.Location = new Point(169, 6);
            lblStatusPesanan.Name = "lblStatusPesanan";
            lblStatusPesanan.Size = new Size(129, 30);
            lblStatusPesanan.TabIndex = 2;
            lblStatusPesanan.Text = "Menunggu Diproses";
            lblStatusPesanan.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalBayar
            // 
            lblTotalBayar.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblTotalBayar.ForeColor = Color.FromArgb(75, 96, 67);
            lblTotalBayar.Location = new Point(304, 6);
            lblTotalBayar.Name = "lblTotalBayar";
            lblTotalBayar.Size = new Size(93, 30);
            lblTotalBayar.TabIndex = 3;
            lblTotalBayar.Text = "Rp 99.999.999";
            lblTotalBayar.TextAlign = ContentAlignment.MiddleLeft;
            lblTotalBayar.Click += lblTotalBayar_Click;
            // 
            // UcRiwayat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 234, 209);
            Controls.Add(lblTotalBayar);
            Controls.Add(lblStatusPesanan);
            Controls.Add(lblNamaBibit);
            Controls.Add(lblIdTransaksi);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UcRiwayat";
            Size = new Size(400, 40);
            ResumeLayout(false);
        }

        #endregion

        public Label lblIdTransaksi;
        public Label lblNamaBibit;
        public Label lblStatusPesanan;
        public Label lblTotalBayar;
    }
}
