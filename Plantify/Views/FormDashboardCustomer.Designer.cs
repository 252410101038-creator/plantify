namespace plantify.Views
{
    partial class FormDashboardCustomer
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
            btnKatalog = new Button();
            btnRiwayat = new Button();
            btnLogout = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnKatalog
            // 
            btnKatalog.BackColor = Color.FromArgb(75, 96, 67);
            btnKatalog.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKatalog.ForeColor = Color.White;
            btnKatalog.Location = new Point(211, 124);
            btnKatalog.Margin = new Padding(3, 2, 3, 2);
            btnKatalog.Name = "btnKatalog";
            btnKatalog.Size = new Size(276, 58);
            btnKatalog.TabIndex = 1;
            btnKatalog.Text = "Katalog";
            btnKatalog.UseVisualStyleBackColor = false;
            btnKatalog.Click += btnKatalog_Click;
            // 
            // btnRiwayat
            // 
            btnRiwayat.BackColor = Color.FromArgb(75, 96, 67);
            btnRiwayat.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayat.ForeColor = Color.White;
            btnRiwayat.Location = new Point(211, 195);
            btnRiwayat.Margin = new Padding(3, 2, 3, 2);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(276, 58);
            btnRiwayat.TabIndex = 2;
            btnRiwayat.Text = "Riwayat";
            btnRiwayat.UseVisualStyleBackColor = false;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(75, 96, 67);
            btnLogout.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(211, 270);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(276, 58);
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
            label1.Location = new Point(131, 77);
            label1.Name = "label1";
            label1.Size = new Size(437, 35);
            label1.TabIndex = 5;
            label1.Text = "Selamat Datang, Customer!";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Plantify.Properties.Resources.plantify;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(584, 4);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 46);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormDashboardCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Plantify.Properties.Resources.Photo_from_n;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(btnRiwayat);
            Controls.Add(btnKatalog);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormDashboardCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDashboardCustomer";
            Load += FormDashboardCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKatalog;
        private Button btnRiwayat;
        private Button btnLogout;
        private Label label1;
        private PictureBox pictureBox1;
    }
}