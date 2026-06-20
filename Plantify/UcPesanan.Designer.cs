namespace Plantify
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
            lblIdTransaksi.Location = new Point(4, 7);
            lblIdTransaksi.Margin = new Padding(4, 0, 4, 0);
            lblIdTransaksi.Name = "lblIdTransaksi";
            lblIdTransaksi.Size = new Size(46, 38);
            lblIdTransaksi.TabIndex = 1;
            lblIdTransaksi.Text = "001";
            lblIdTransaksi.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStatusPesanan
            // 
            lblStatusPesanan.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblStatusPesanan.ForeColor = Color.FromArgb(75, 96, 67);
            lblStatusPesanan.Location = new Point(76, 7);
            lblStatusPesanan.Margin = new Padding(4, 0, 4, 0);
            lblStatusPesanan.Name = "lblStatusPesanan";
            lblStatusPesanan.Size = new Size(197, 38);
            lblStatusPesanan.TabIndex = 3;
            lblStatusPesanan.Text = "Menunggu Diproses";
            lblStatusPesanan.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UcPesanan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblStatusPesanan);
            Controls.Add(lblIdTransaksi);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UcPesanan";
            Size = new Size(277, 50);
            ResumeLayout(false);
        }

        #endregion

        public Label lblIdTransaksi;
        public Label lblStatusPesanan;
    }
}
