namespace plantify.Views
{
    partial class UcPesanan
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
            lblStatusPesanan = new Label();
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
            lblIdTransaksi.TabIndex = 1;
            lblIdTransaksi.Text = "001";
            lblIdTransaksi.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStatusPesanan
            // 
            lblStatusPesanan.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblStatusPesanan.ForeColor = Color.FromArgb(75, 96, 67);
            lblStatusPesanan.Location = new Point(61, 6);
            lblStatusPesanan.Name = "lblStatusPesanan";
            lblStatusPesanan.Size = new Size(158, 30);
            lblStatusPesanan.TabIndex = 3;
            lblStatusPesanan.Text = "Menunggu Diproses";
            lblStatusPesanan.TextAlign = ContentAlignment.MiddleLeft;
            lblStatusPesanan.Click += lblStatusPesanan_Click;
            // 
            // UcPesanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblStatusPesanan);
            Controls.Add(lblIdTransaksi);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UcPesanan";
            Size = new Size(222, 40);
            ResumeLayout(false);
        }

        #endregion

        public Label lblIdTransaksi;
        public Label lblStatusPesanan;
    }
}
