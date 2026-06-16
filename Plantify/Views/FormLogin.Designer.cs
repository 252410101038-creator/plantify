namespace plantify.Views
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            lblJudul = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnKeRegister = new Button();
            lblError = new Label();
            panelkiri = new Panel();
            label1 = new Label();
            pctLogo = new PictureBox();
            lblTanyaAkun = new Label();
            ((System.ComponentModel.ISupportInitialize)pctLogo).BeginInit();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.FromArgb(75, 96, 67);
            lblJudul.Location = new Point(371, 106);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(162, 15);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Masuk ke akun Plantify-mu!";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(371, 130);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(371, 154);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(275, 23);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(371, 184);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(371, 211);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(275, 23);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(75, 96, 67);
            btnLogin.BackgroundImageLayout = ImageLayout.Center;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(371, 263);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(275, 28);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnKeRegister
            // 
            btnKeRegister.BackColor = Color.Transparent;
            btnKeRegister.FlatAppearance.BorderColor = Color.FromArgb(221, 234, 209);
            btnKeRegister.FlatAppearance.BorderSize = 0;
            btnKeRegister.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKeRegister.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKeRegister.FlatStyle = FlatStyle.Flat;
            btnKeRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKeRegister.ForeColor = Color.FromArgb(75, 96, 67);
            btnKeRegister.Location = new Point(547, 299);
            btnKeRegister.Margin = new Padding(3, 2, 3, 2);
            btnKeRegister.Name = "btnKeRegister";
            btnKeRegister.Size = new Size(109, 22);
            btnKeRegister.TabIndex = 6;
            btnKeRegister.Text = "Daftar di sini";
            btnKeRegister.UseVisualStyleBackColor = false;
            btnKeRegister.Click += btnKeRegister_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(452, 317);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 7;
            // 
            // panelkiri
            // 
            panelkiri.BackColor = Color.FromArgb(199, 221, 181);
            panelkiri.BackgroundImage = (Image)resources.GetObject("panelkiri.BackgroundImage");
            panelkiri.BackgroundImageLayout = ImageLayout.Stretch;
            panelkiri.Dock = DockStyle.Left;
            panelkiri.Location = new Point(0, 0);
            panelkiri.Margin = new Padding(3, 2, 3, 2);
            panelkiri.Name = "panelkiri";
            panelkiri.Size = new Size(289, 338);
            panelkiri.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(75, 96, 67);
            label1.Location = new Point(354, 56);
            label1.Name = "label1";
            label1.Size = new Size(292, 24);
            label1.TabIndex = 0;
            label1.Text = "Selamat Datang di Plantify!";
            // 
            // pctLogo
            // 
            pctLogo.BackColor = Color.Transparent;
            pctLogo.BackgroundImage = Plantify.Properties.Resources.a7e06774_5e62_4ee1_a088_40968eabf182;
            pctLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pctLogo.Location = new Point(568, 5);
            pctLogo.Margin = new Padding(3, 2, 3, 2);
            pctLogo.Name = "pctLogo";
            pctLogo.Size = new Size(108, 45);
            pctLogo.TabIndex = 9;
            pctLogo.TabStop = false;
            // 
            // lblTanyaAkun
            // 
            lblTanyaAkun.AutoSize = true;
            lblTanyaAkun.Location = new Point(439, 302);
            lblTanyaAkun.Name = "lblTanyaAkun";
            lblTanyaAkun.Size = new Size(111, 15);
            lblTanyaAkun.TabIndex = 10;
            lblTanyaAkun.Text = "Belum punya akun?";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 234, 209);
            ClientSize = new Size(700, 338);
            Controls.Add(lblTanyaAkun);
            Controls.Add(label1);
            Controls.Add(pctLogo);
            Controls.Add(panelkiri);
            Controls.Add(lblError);
            Controls.Add(btnKeRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblJudul);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pctLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnKeRegister;
        private Label lblError;
        private Panel panelkiri;
        private Label label1;
        private PictureBox pctLogo;
        private Label lblTanyaAkun;
    }
}