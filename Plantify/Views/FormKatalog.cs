using System.Collections.Generic;
using plantify.Controllers;
using plantify.Models;
using Plantify;
using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace plantify.Views
{
    public partial class FormKatalog : Form
    {
        private Customer _customerLogin;

        private FormDashboardCustomer _dashboardCustomer;

        private BibitController _bibitController = new BibitController();

        public FormKatalog(Customer customer)

        {
            InitializeComponent();

            _customerLogin = customer;

        }
        public FormKatalog(Customer customer, FormDashboardCustomer dashboardCustomer)
        {
            InitializeComponent();

            _customerLogin = customer;
            _dashboardCustomer = dashboardCustomer;
        }
        private void FormKatalog_Load(object sender, EventArgs e)
        {
            lblSambutan.Text = $"Selamat datang, {_customerLogin.Nama}!";
            MuatKatalog();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            //dgvKatalog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgvKatalog.MultiSelect = false;
            //dgvKatalog.ReadOnly = true;
            //dgvKatalog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void MuatKatalog(string keyword = "", string kategori = "")
        {
            try
            {
                DataTable dt = _bibitController.GetKatalog(keyword, kategori);

                flpKatalog.Controls.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    UcBibit card = new UcBibit();

                    card.Tag = row;
                    card.Click += CardBibit_Click;

                    card.lblNama.Text = row["Nama Bibit"].ToString();
                    card.lblKategori.Text = row["Kategori"].ToString();
                    card.lblStock.Text = "Stock : " + row["Stok"].ToString();
                    card.lblHarga.Text = "Rp " + row["Harga (Rp)"].ToString();

                    string gambar = row["gambar"].ToString();

                    if (!string.IsNullOrEmpty(gambar) && File.Exists(gambar))
                    {
                        card.pbGambar.Image = Image.FromFile(gambar);
                    }

                    flpKatalog.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat katalog: " + ex.Message);
            }
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    string keyword = txtCari.Text.Trim();
            //    string kategori = cmbKategori.SelectedItem?.ToString() ?? "";
            //    MuatKatalog(keyword, kategori);
        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            var hasil = MessageBox.Show("Yakin ingin logout?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (hasil == DialogResult.Yes)
            {
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Close();
            }
        }

        private DataRow selectedBibit;

        private void CardBibit_Click(object sender, EventArgs e)
        {
            UcBibit card = (UcBibit)sender;

            selectedBibit = (DataRow)card.Tag;

            lblNamaProduk.Text = selectedBibit["nama_bibit"].ToString();

            lblDeskripsi.Text =
                selectedBibit["deskripsi"].ToString();

            string gambar = selectedBibit["gambar"].ToString();

            if (!string.IsNullOrEmpty(gambar) &&
                File.Exists(gambar))
            {
                pbDetail.Image = Image.FromFile(gambar);
            }
        }

        private void Card1_Click(object sender, EventArgs e)
        {
            lblNamaProduk.Text = "Bibit Tomat";

            lblDeskripsi.Text =
                "Bibit tomat unggul. Cocok ditanam di dataran rendah dan memiliki masa panen sekitar 70 hari.";
        }

        private void btnCari_Click_1(object sender, EventArgs e)
        {
            string keyword = txtCari.Text.Trim();

            MuatKatalog(keyword);
        }

        private void cmbKategori_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            MuatKatalog(txtCari.Text.Trim());
        }

        private void lblNamaProduk_Click(object sender, EventArgs e)
        {

        }

        private void lblKategori_Click(object sender, EventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            _dashboardCustomer.Show();
            this.Close();
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            if (selectedBibit == null)
            {
                MessageBox.Show("Pilih bibit terlebih dahulu!");
                return;
            }

            FormTransaksi transaksi =
            new FormTransaksi(
            selectedBibit,
            _customerLogin,
            this);

            transaksi.Show();

            this.Hide();
        }

        private void pbDetail_Click(object sender, EventArgs e)
        {

        }
    }
}