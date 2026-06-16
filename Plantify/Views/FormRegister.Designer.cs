namespace plantify.Views
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            lblJudul = new Label();
            lblNama = new Label();
            txtNama = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblKonfirm = new Label();
            txtKonfirmPassword = new TextBox();
            lblAlamat = new Label();
            txtAlamat = new TextBox();
            lblNoHp = new Label();
            txtNoHp = new TextBox();
            btnDaftar = new Button();
            btnKeLogin = new Button();
            lblError = new Label();
            lblTanyaRegister = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.FromArgb(75, 96, 67);
            lblJudul.Location = new Point(364, 7);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(165, 29);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Daftar Akun";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(220, 32);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(87, 15);
            lblNama.TabIndex = 1;
            lblNama.Text = "Nama Lengkap";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(220, 50);
            txtNama.Margin = new Padding(3, 2, 3, 2);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(451, 23);
            txtNama.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(220, 76);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(220, 93);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 23);
            txtEmail.TabIndex = 4;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(220, 159);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(220, 176);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(451, 23);
            txtUsername.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(220, 203);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(220, 220);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(210, 23);
            txtPassword.TabIndex = 8;
            // 
            // lblKonfirm
            // 
            lblKonfirm.AutoSize = true;
            lblKonfirm.Location = new Point(468, 203);
            lblKonfirm.Name = "lblKonfirm";
            lblKonfirm.Size = new Size(117, 15);
            lblKonfirm.TabIndex = 9;
            lblKonfirm.Text = "Konfirmasi Password";
            // 
            // txtKonfirmPassword
            // 
            txtKonfirmPassword.Location = new Point(468, 220);
            txtKonfirmPassword.Margin = new Padding(3, 2, 3, 2);
            txtKonfirmPassword.Name = "txtKonfirmPassword";
            txtKonfirmPassword.PasswordChar = '*';
            txtKonfirmPassword.Size = new Size(203, 23);
            txtKonfirmPassword.TabIndex = 10;
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Location = new Point(220, 118);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(45, 15);
            lblAlamat.TabIndex = 11;
            lblAlamat.Text = "Alamat";
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(220, 135);
            txtAlamat.Margin = new Padding(3, 2, 3, 2);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(451, 23);
            txtAlamat.TabIndex = 12;
            // 
            // lblNoHp
            // 
            lblNoHp.AutoSize = true;
            lblNoHp.Location = new Point(468, 76);
            lblNoHp.Name = "lblNoHp";
            lblNoHp.Size = new Size(45, 15);
            lblNoHp.TabIndex = 13;
            lblNoHp.Text = "No. HP";
            // 
            // txtNoHp
            // 
            txtNoHp.Location = new Point(468, 94);
            txtNoHp.Margin = new Padding(3, 2, 3, 2);
            txtNoHp.Name = "txtNoHp";
            txtNoHp.Size = new Size(203, 23);
            txtNoHp.TabIndex = 14;
            // 
            // btnDaftar
            // 
            btnDaftar.BackColor = Color.FromArgb(75, 96, 67);
            btnDaftar.BackgroundImageLayout = ImageLayout.None;
            btnDaftar.FlatAppearance.BorderColor = Color.FromArgb(75, 96, 67);
            btnDaftar.FlatAppearance.BorderSize = 0;
            btnDaftar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDaftar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnDaftar.FlatStyle = FlatStyle.Popup;
            btnDaftar.ForeColor = Color.White;
            btnDaftar.Location = new Point(502, 260);
            btnDaftar.Margin = new Padding(3, 2, 3, 2);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(168, 33);
            btnDaftar.TabIndex = 15;
            btnDaftar.Text = "Daftar";
            btnDaftar.UseVisualStyleBackColor = false;
            btnDaftar.Click += btnDaftar_Click;
            // 
            // btnKeLogin
            // 
            btnKeLogin.FlatAppearance.BorderSize = 0;
            btnKeLogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKeLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKeLogin.FlatStyle = FlatStyle.Flat;
            btnKeLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKeLogin.ForeColor = Color.FromArgb(75, 96, 67);
            btnKeLogin.Location = new Point(606, 296);
            btnKeLogin.Margin = new Padding(3, 2, 3, 2);
            btnKeLogin.Name = "btnKeLogin";
            btnKeLogin.Size = new Size(71, 22);
            btnKeLogin.TabIndex = 16;
            btnKeLogin.Text = "Masuk";
            btnKeLogin.UseVisualStyleBackColor = true;
            btnKeLogin.Click += btnKeLogin_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(502, 319);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 17;
            // 
            // lblTanyaRegister
            // 
            lblTanyaRegister.AutoSize = true;
            lblTanyaRegister.Location = new Point(497, 298);
            lblTanyaRegister.Name = "lblTanyaRegister";
            lblTanyaRegister.Size = new Size(110, 15);
            lblTanyaRegister.TabIndex = 18;
            lblTanyaRegister.Text = "Sudah punya akun?";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(-94, -4);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 344);
            panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Plantify.Properties.Resources.a7e06774_5e62_4ee1_a088_40968eabf182;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(208, 257);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 46);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 234, 209);
            ClientSize = new Size(700, 338);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(lblTanyaRegister);
            Controls.Add(lblError);
            Controls.Add(btnKeLogin);
            Controls.Add(btnDaftar);
            Controls.Add(txtNoHp);
            Controls.Add(lblNoHp);
            Controls.Add(txtAlamat);
            Controls.Add(lblAlamat);
            Controls.Add(txtKonfirmPassword);
            Controls.Add(lblKonfirm);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtNama);
            Controls.Add(lblNama);
            Controls.Add(lblJudul);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormRegister";
            Text = "FormRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        private Label lblNama;
        private TextBox txtNama;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblKonfirm;
        private TextBox txtKonfirmPassword;
        private Label lblAlamat;
        private TextBox txtAlamat;
        private Label lblNoHp;
        private TextBox txtNoHp;
        private Button btnDaftar;
        private Button btnKeLogin;
        private Label lblError;
        private Label lblTanyaRegister;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}