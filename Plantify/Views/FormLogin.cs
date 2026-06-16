using System;
using System.Windows.Forms;
using plantify.Controllers;
using plantify.Models;
using plantify.Views;

namespace plantify.Views
{
    public partial class FormLogin : Form
    {
        private AuthController _authController = new AuthController();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Username dan password tidak boleh kosong!";
                return;
            }

            try
            {
                // Panggil controller, bukan logika langsung
                // Login admin manual
                if (username == "admin" && password == "admin123")
                {
                    FormDashboardAdmin adminDashboard = new FormDashboardAdmin();
                    adminDashboard.Show();
                    this.Hide();
                }
                else
                {
                    Customer customer = _authController.Login(username, password);

                    if (customer != null)
                    {
                        FormDashboardCustomer customerDashboard =
                            new FormDashboardCustomer(customer);

                        customerDashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        lblError.Text = "Username atau password salah!";
                        txtPassword.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Kesalahan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKeRegister_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
            this.Hide();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}