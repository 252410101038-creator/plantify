namespace plantify.Views
{
    partial class FormTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransaksi));
            lblNamaBibit = new Label();
            lblHarga = new Label();
            lblJumlah = new Label();
            numJumlah = new NumericUpDown();
            lblTextTotal = new Label();
            lblTotal = new Label();
            btnBayar = new Button();
            picBibit = new PictureBox();
            lblDetailNamaBibit = new Label();
            lblDetailJenisBibit = new Label();
            lblDetailHarga = new Label();
            lblDetailStok = new Label();
            rtbDeskripsi = new RichTextBox();
            btnKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)numJumlah).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBibit).BeginInit();
            SuspendLayout();
            // 
            // lblNamaBibit
            // 
            lblNamaBibit.Font = new Font("Georgia", 7F);
            lblNamaBibit.ForeColor = Color.FromArgb(75, 96, 67);
            lblNamaBibit.Location = new Point(21, 175);
            lblNamaBibit.Margin = new Padding(2, 0, 2, 0);
            lblNamaBibit.Name = "lblNamaBibit";
            lblNamaBibit.Size = new Size(167, 17);
            lblNamaBibit.TabIndex = 0;
            lblNamaBibit.Text = "Nama Bibit :";
            // 
            // lblHarga
            // 
            lblHarga.Font = new Font("Georgia", 7F);
            lblHarga.ForeColor = Color.FromArgb(75, 96, 67);
            lblHarga.Location = new Point(21, 201);
            lblHarga.Margin = new Padding(2, 0, 2, 0);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(167, 17);
            lblHarga.TabIndex = 1;
            lblHarga.Text = "Harga :";
            lblHarga.Click += lblHarga_Click_1;
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Font = new Font("Georgia", 7F);
            lblJumlah.ForeColor = Color.FromArgb(75, 96, 67);
            lblJumlah.Location = new Point(21, 227);
            lblJumlah.Margin = new Padding(2, 0, 2, 0);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(51, 13);
            lblJumlah.TabIndex = 2;
            lblJumlah.Text = "Jumlah :";
            lblJumlah.Click += label1_Click;
            // 
            // numJumlah
            // 
            numJumlah.Font = new Font("Georgia", 7F);
            numJumlah.ForeColor = Color.FromArgb(75, 96, 67);
            numJumlah.Location = new Point(75, 225);
            numJumlah.Margin = new Padding(1);
            numJumlah.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numJumlah.Name = "numJumlah";
            numJumlah.Size = new Size(113, 18);
            numJumlah.TabIndex = 3;
            numJumlah.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numJumlah.ValueChanged += numJumlah_ValueChanged;
            // 
            // lblTextTotal
            // 
            lblTextTotal.AutoSize = true;
            lblTextTotal.BackColor = SystemColors.Control;
            lblTextTotal.Font = new Font("Georgia", 12F, FontStyle.Bold);
            lblTextTotal.ForeColor = Color.FromArgb(75, 96, 67);
            lblTextTotal.Location = new Point(215, 232);
            lblTextTotal.Margin = new Padding(2, 0, 2, 0);
            lblTextTotal.Name = "lblTextTotal";
            lblTextTotal.Size = new Size(63, 18);
            lblTextTotal.TabIndex = 4;
            lblTextTotal.Text = "Total :";
            lblTextTotal.Click += lblTextTotal_Click;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = SystemColors.Control;
            lblTotal.Font = new Font("Georgia", 12F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(75, 96, 67);
            lblTotal.Location = new Point(276, 231);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(142, 17);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Rp 0";
            lblTotal.Click += lblTotal_Click;
            // 
            // btnBayar
            // 
            btnBayar.BackColor = Color.FromArgb(75, 96, 67);
            btnBayar.Font = new Font("Georgia", 9F, FontStyle.Bold);
            btnBayar.ForeColor = Color.White;
            btnBayar.Location = new Point(423, 227);
            btnBayar.Margin = new Padding(2);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(125, 26);
            btnBayar.TabIndex = 6;
            btnBayar.Text = "Bayar";
            btnBayar.UseVisualStyleBackColor = false;
            btnBayar.Click += btnBayar_Click;
            // 
            // picBibit
            // 
            picBibit.Location = new Point(13, 44);
            picBibit.Margin = new Padding(2);
            picBibit.Name = "picBibit";
            picBibit.Size = new Size(183, 114);
            picBibit.SizeMode = PictureBoxSizeMode.StretchImage;
            picBibit.TabIndex = 0;
            picBibit.TabStop = false;
            picBibit.Click += picBibit_Click;
            // 
            // lblDetailNamaBibit
            // 
            lblDetailNamaBibit.Font = new Font("Georgia", 8F);
            lblDetailNamaBibit.ForeColor = Color.FromArgb(75, 96, 67);
            lblDetailNamaBibit.Location = new Point(299, 70);
            lblDetailNamaBibit.Margin = new Padding(2, 0, 2, 0);
            lblDetailNamaBibit.Name = "lblDetailNamaBibit";
            lblDetailNamaBibit.Size = new Size(247, 13);
            lblDetailNamaBibit.TabIndex = 12;
            lblDetailNamaBibit.Text = "-";
            lblDetailNamaBibit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDetailJenisBibit
            // 
            lblDetailJenisBibit.Font = new Font("Georgia", 8F);
            lblDetailJenisBibit.ForeColor = Color.FromArgb(75, 96, 67);
            lblDetailJenisBibit.Location = new Point(299, 88);
            lblDetailJenisBibit.Margin = new Padding(2, 0, 2, 0);
            lblDetailJenisBibit.Name = "lblDetailJenisBibit";
            lblDetailJenisBibit.Size = new Size(247, 13);
            lblDetailJenisBibit.TabIndex = 13;
            lblDetailJenisBibit.Text = "-";
            lblDetailJenisBibit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDetailHarga
            // 
            lblDetailHarga.Font = new Font("Georgia", 8F);
            lblDetailHarga.ForeColor = Color.FromArgb(75, 96, 67);
            lblDetailHarga.Location = new Point(299, 106);
            lblDetailHarga.Margin = new Padding(2, 0, 2, 0);
            lblDetailHarga.Name = "lblDetailHarga";
            lblDetailHarga.Size = new Size(247, 13);
            lblDetailHarga.TabIndex = 14;
            lblDetailHarga.Text = "-";
            lblDetailHarga.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDetailStok
            // 
            lblDetailStok.Font = new Font("Georgia", 8F);
            lblDetailStok.ForeColor = Color.FromArgb(75, 96, 67);
            lblDetailStok.Location = new Point(299, 124);
            lblDetailStok.Margin = new Padding(2, 0, 2, 0);
            lblDetailStok.Name = "lblDetailStok";
            lblDetailStok.Size = new Size(247, 13);
            lblDetailStok.TabIndex = 15;
            lblDetailStok.Text = "-";
            lblDetailStok.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rtbDeskripsi
            // 
            rtbDeskripsi.Font = new Font("Georgia", 8F);
            rtbDeskripsi.ForeColor = Color.FromArgb(75, 96, 67);
            rtbDeskripsi.Location = new Point(215, 161);
            rtbDeskripsi.Margin = new Padding(2);
            rtbDeskripsi.Name = "rtbDeskripsi";
            rtbDeskripsi.ReadOnly = true;
            rtbDeskripsi.Size = new Size(332, 65);
            rtbDeskripsi.TabIndex = 17;
            rtbDeskripsi.Text = "Deskripsi bibit akan tampil di sini";
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.FromArgb(75, 96, 67);
            btnKembali.Font = new Font("Georgia", 9F);
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(13, 14);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(86, 23);
            btnKembali.TabIndex = 8;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += button1_Click;
            // 
            // FormTransaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(560, 270);
            ControlBox = false;
            Controls.Add(btnKembali);
            Controls.Add(rtbDeskripsi);
            Controls.Add(btnBayar);
            Controls.Add(lblDetailStok);
            Controls.Add(lblTotal);
            Controls.Add(lblDetailHarga);
            Controls.Add(lblTextTotal);
            Controls.Add(lblDetailJenisBibit);
            Controls.Add(numJumlah);
            Controls.Add(lblDetailNamaBibit);
            Controls.Add(lblJumlah);
            Controls.Add(lblHarga);
            Controls.Add(lblNamaBibit);
            Controls.Add(picBibit);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "FormTransaksi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transaksi Pembelian";
            Load += FormTransaksi_Load;
            ((System.ComponentModel.ISupportInitialize)numJumlah).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBibit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNamaBibit;
        private Label lblHarga;
        private Label lblJumlah;
        private NumericUpDown numJumlah;
        private Label lblTextTotal;
        private Label lblTotal;
        private Button btnBayar;
        private PictureBox picBibit;
        private Label lblDetailNamaBibit;
        private Label lblDetailJenisBibit;
        private Label lblDetailHarga;
        private Label lblDetailStok;
        private RichTextBox rtbDeskripsi;
        private Button btnKembali;
    }
}