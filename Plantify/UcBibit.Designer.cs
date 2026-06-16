namespace Plantify
{
    partial class UcBibit
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
            pbGambar = new PictureBox();
            lblNama = new Label();
            lblKategori = new Label();
            lblStock = new Label();
            lblHarga = new Label();
            ((System.ComponentModel.ISupportInitialize)pbGambar).BeginInit();
            SuspendLayout();
            // 
            // pbGambar
            // 
            pbGambar.Location = new Point(3, 2);
            pbGambar.Margin = new Padding(3, 2, 3, 2);
            pbGambar.Name = "pbGambar";
            pbGambar.Size = new Size(97, 50);
            pbGambar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGambar.TabIndex = 0;
            pbGambar.TabStop = false;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNama.Location = new Point(3, 54);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(71, 15);
            lblNama.TabIndex = 1;
            lblNama.Text = "Bibit Tomat";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKategori.Location = new Point(3, 69);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(35, 13);
            lblKategori.TabIndex = 2;
            lblKategori.Text = "Sayur";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(3, 82);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(56, 13);
            lblStock.TabIndex = 3;
            lblStock.Text = "Stock : 20";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHarga.Location = new Point(3, 95);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(48, 13);
            lblHarga.TabIndex = 4;
            lblHarga.Text = "Rp5.000";
            // 
            // UcBibit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblHarga);
            Controls.Add(lblStock);
            Controls.Add(lblKategori);
            Controls.Add(lblNama);
            Controls.Add(pbGambar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UcBibit";
            Size = new Size(103, 115);
            Load += UcBibit_Load;
            ((System.ComponentModel.ISupportInitialize)pbGambar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox pbGambar;
        public Label lblNama;
        public Label lblKategori;
        public Label lblStock;
        public Label lblHarga;
    }
}
