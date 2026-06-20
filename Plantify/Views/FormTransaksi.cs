using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using plantify.Models;

namespace plantify.Views
{
    public partial class FormTransaksi : Form
    {
        private int totalBayar = 0;
        private int harga;
        private int idBibit;
        private string namaBibit;
        private string jenisBibit;
        private string deskripsi;
        private string gambar;
        private int stok;
        private FormKatalog _formKatalog;
        private Customer _customer;
        public FormTransaksi()
        {
            InitializeComponent();
        }
        public FormKatalog FormKatalogAsal
        {
            get { return _formKatalog; }
        }
        public FormTransaksi(
            string namaBibit,
            string jenisBibit,
            string deskripsi,
            int harga,
            int stok)
        {
            InitializeComponent();

            this.namaBibit = namaBibit;
            this.jenisBibit = jenisBibit;
            this.deskripsi = deskripsi;
            this.harga = harga;
            this.stok = stok;
        }
        public FormTransaksi(
            DataRow bibit,
            Customer customer,
            FormKatalog formKatalog)
        {
            InitializeComponent();

            this.namaBibit = bibit["nama_bibit"].ToString();
            this.jenisBibit = bibit["jenis_bibit"].ToString();
            this.deskripsi = bibit["deskripsi"].ToString();
            this.harga = Convert.ToInt32(bibit["harga"]);
            this.gambar = bibit["gambar"].ToString();
            this.stok = Convert.ToInt32(bibit["stok"]);
            this.idBibit = Convert.ToInt32(bibit["id_bibit"]);

            _customer = customer;
            _formKatalog = formKatalog;
        }
        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            lblNamaBibit.Text = "Nama Bibit : " + namaBibit;
            lblHarga.Text = "Harga : Rp " + harga.ToString("N0");

            lblDetailNamaBibit.Text = namaBibit;
            lblDetailJenisBibit.Text = jenisBibit;
            lblDetailHarga.Text = "Rp " + harga.ToString("N0");
            lblDetailStok.Text = stok.ToString();
            numJumlah.Maximum = stok;

            rtbDeskripsi.Text = deskripsi;
            if (!string.IsNullOrEmpty(gambar) &&
    File.Exists(gambar))
            {
                picBibit.Image = Image.FromFile(gambar);
            }
            int jumlah = (int)numJumlah.Value;

            totalBayar = harga * jumlah;

            lblTotal.Text = "Rp " + totalBayar.ToString("N0");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblHarga_Click(object sender, EventArgs e)
        {

        }

        private void panelDetail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picBibit_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            int jumlah = (int)numJumlah.Value;
            if (jumlah > stok)
            {
                MessageBox.Show(
                    "Jumlah pembelian melebihi stok yang tersedia!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            totalBayar = harga * jumlah;

            MessageBox.Show(totalBayar.ToString());
            FormPembayaran pembayaran = new FormPembayaran();
            pembayaran.totalBayar = totalBayar;
            pembayaran.idBibit = idBibit;
            pembayaran.jumlah = jumlah;
            pembayaran.idUser = _customer.Id;

            pembayaran.Owner = this;
            pembayaran.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _formKatalog.Show();
            this.Close();
        }

        private void lblTextTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblHarga_Click_1(object sender, EventArgs e)
        {

        }

        private void numJumlah_ValueChanged(object sender, EventArgs e)
        {
            int jumlah = (int)numJumlah.Value;

            totalBayar = harga * jumlah;

            lblTotal.Text = "Rp " + totalBayar.ToString("N0");
        }
    }
}