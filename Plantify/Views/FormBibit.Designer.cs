namespace plantify.Views
{
    partial class FormBibit
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBibit));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNama = new TextBox();
            txtHarga = new TextBox();
            txtStok = new TextBox();
            dataGridView1 = new DataGridView();
            btnSearch = new Button();
            btnTambah = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            btnReset = new Button();
            rtbDeskripsi = new RichTextBox();
            txtSearch = new TextBox();
            label6 = new Label();
            cmbJenis = new ComboBox();
            Plantify = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            btnUpload = new Button();
            panelInput = new Panel();
            panelGambar = new Panel();
            picLogo = new PictureBox();
            btnKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelGambar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(199, 221, 181);
            label1.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 107);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Nama Bibit";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(199, 221, 181);
            label2.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 139);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Jenis";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(199, 221, 181);
            label3.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, 172);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Harga";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(199, 221, 181);
            label4.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(60, 205);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 3;
            label4.Text = "Stok";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(199, 221, 181);
            label5.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(60, 240);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 4;
            label5.Text = "Deskripsi Bibit";
            // 
            // txtNama
            // 
            txtNama.BackColor = Color.White;
            txtNama.Location = new Point(215, 98);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(170, 23);
            txtNama.TabIndex = 5;
            // 
            // txtHarga
            // 
            txtHarga.BackColor = Color.White;
            txtHarga.Location = new Point(215, 165);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(170, 23);
            txtHarga.TabIndex = 7;
            txtHarga.TextChanged += txtHarga_TextChanged;
            // 
            // txtStok
            // 
            txtStok.BackColor = Color.White;
            txtStok.Location = new Point(215, 198);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(170, 23);
            txtStok.TabIndex = 8;
            txtStok.TextChanged += txtStok_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(135, 171, 105);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(60, 369);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(686, 69);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(101, 131, 84);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(489, 334);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(107, 29);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Cari";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnTambah
            // 
            btnTambah.Anchor = AnchorStyles.Top;
            btnTambah.BackColor = Color.FromArgb(101, 131, 84);
            btnTambah.FlatAppearance.BorderSize = 0;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(155, 290);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(120, 30);
            btnTambah.TabIndex = 12;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top;
            btnEdit.BackColor = Color.FromArgb(101, 131, 84);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(284, 290);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 30);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.Anchor = AnchorStyles.Top;
            btnHapus.BackColor = Color.FromArgb(101, 131, 84);
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(413, 290);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(120, 30);
            btnHapus.TabIndex = 14;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Top;
            btnReset.BackColor = Color.FromArgb(101, 131, 84);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(542, 290);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 30);
            btnReset.TabIndex = 15;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // rtbDeskripsi
            // 
            rtbDeskripsi.BackColor = Color.White;
            rtbDeskripsi.Location = new Point(215, 231);
            rtbDeskripsi.Name = "rtbDeskripsi";
            rtbDeskripsi.Size = new Size(170, 29);
            rtbDeskripsi.TabIndex = 16;
            rtbDeskripsi.Text = "";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.BackColor = Color.White;
            txtSearch.Location = new Point(314, 336);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(154, 23);
            txtSearch.TabIndex = 17;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(206, 340);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 18;
            label6.Text = "Cari Bibit";
            // 
            // cmbJenis
            // 
            cmbJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenis.FormattingEnabled = true;
            cmbJenis.Items.AddRange(new object[] { "Sayur", "Buah", "Bunga", "Tanaman Hias" });
            cmbJenis.Location = new Point(215, 131);
            cmbJenis.Name = "cmbJenis";
            cmbJenis.Size = new Size(170, 23);
            cmbJenis.TabIndex = 19;
            // 
            // Plantify
            // 
            Plantify.Anchor = AnchorStyles.Top;
            Plantify.AutoSize = true;
            Plantify.BackColor = Color.Transparent;
            Plantify.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Plantify.ForeColor = Color.OliveDrab;
            Plantify.Location = new Point(335, 10);
            Plantify.Name = "Plantify";
            Plantify.Size = new Size(0, 27);
            Plantify.TabIndex = 20;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SaddleBrown;
            label7.Location = new Point(267, 42);
            label7.Name = "label7";
            label7.Size = new Size(0, 18);
            label7.TabIndex = 21;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(97, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnUpload
            // 
            btnUpload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpload.BackColor = Color.FromArgb(101, 131, 84);
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpload.ForeColor = Color.White;
            btnUpload.Location = new Point(200, 158);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(107, 29);
            btnUpload.TabIndex = 23;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // panelInput
            // 
            panelInput.BackColor = Color.FromArgb(199, 221, 181);
            panelInput.BorderStyle = BorderStyle.FixedSingle;
            panelInput.Location = new Point(48, 81);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(354, 203);
            panelInput.TabIndex = 24;
            panelInput.Paint += panel1_Paint;
            // 
            // panelGambar
            // 
            panelGambar.BackColor = Color.FromArgb(199, 221, 181);
            panelGambar.BorderStyle = BorderStyle.FixedSingle;
            panelGambar.Controls.Add(btnUpload);
            panelGambar.Controls.Add(pictureBox1);
            panelGambar.Location = new Point(438, 81);
            panelGambar.Name = "panelGambar";
            panelGambar.Size = new Size(320, 203);
            panelGambar.TabIndex = 25;
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(284, -13);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(246, 115);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 26;
            picLogo.TabStop = false;
            picLogo.Click += picLogo_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.FromArgb(101, 131, 84);
            btnKembali.FlatStyle = FlatStyle.Flat;
            btnKembali.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(48, 25);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(94, 29);
            btnKembali.TabIndex = 27;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // FormBibit
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(221, 234, 209);
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnKembali);
            Controls.Add(label7);
            Controls.Add(Plantify);
            Controls.Add(cmbJenis);
            Controls.Add(label6);
            Controls.Add(txtSearch);
            Controls.Add(rtbDeskripsi);
            Controls.Add(btnReset);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(btnTambah);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Controls.Add(txtStok);
            Controls.Add(txtHarga);
            Controls.Add(txtNama);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelInput);
            Controls.Add(panelGambar);
            Controls.Add(picLogo);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormBibit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD Bibit Tanaman";
            Load += FormBibit_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelGambar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNama;
        private TextBox txtHarga;
        private TextBox txtStok;
        private DataGridView dataGridView1;
        private Button btnSearch;
        private Button btnTambah;
        private Button btnEdit;
        private Button btnHapus;
        private Button btnReset;
        private RichTextBox rtbDeskripsi;
        private TextBox txtSearch;
        private Label label6;
        private ComboBox cmbJenis;
        private Label Plantify;
        private Label label7;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button btnUpload;
        private Panel panelInput;
        private Panel panelGambar;
        private PictureBox picLogo;
        private Button btnKembali;
    }
}
