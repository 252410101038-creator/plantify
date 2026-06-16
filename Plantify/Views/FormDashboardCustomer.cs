using plantify.Models;
using Plantify.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace plantify.Views
{
    public partial class FormDashboardCustomer : Form
    {
        private Customer _customer;

        public FormDashboardCustomer()
        {
            InitializeComponent();
        }

        public FormDashboardCustomer(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
        }

        private void FormDashboardCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show(
                                "Yakin ingin logout?",
                                "Konfirmasi Logout",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

            if (hasil == DialogResult.Yes)
            {
                FormLogin login = new FormLogin();
                login.Show();

                this.Close();
            }
        }

        private void btnKatalog_Click(object sender, EventArgs e)
        {
            FormKatalog katalog = new FormKatalog(_customer, this);
            katalog.Show();
            this.Hide();
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            FormRiwayatPembelian riwayat =
                new FormRiwayatPembelian(_customer);

            riwayat.Owner = this;

            riwayat.Show();

            this.Hide();
        }
    }
}