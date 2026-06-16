using Npgsql;
using plantify.Database;
using plantify.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Plantify.Views
{
    public partial class FormRiwayatPembelian : Form
    {
        private Customer _customer;
        public FormRiwayatPembelian(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
        }
        private void LoadRiwayat()
        {
            try
            {
                NpgsqlConnection conn = DBConnection.GetConnection();

                string query = @"
        SELECT
            t.id_transaksi,
            b.nama_bibit,
            t.status_pesanan,
            t.total_bayar
        FROM transaksi t
        JOIN detail_transaksi dt
            ON t.id_transaksi = dt.id_transaksi
        JOIN bibit b
            ON dt.id_bibit = b.id_bibit
        WHERE t.id_user = @id_user
        ORDER BY t.tanggal_transaksi DESC";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id_user", _customer.Id);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                flpRiwayat.Controls.Clear();

                while (dr.Read())
                {
                    UcRiwayat card = new UcRiwayat();

                    card.Tag = dr["id_transaksi"];

                    card.Click += Card_Click;

                    card.lblIdTransaksi.Text =
                        "#" + dr["id_transaksi"].ToString();

                    card.lblNamaBibit.Text =
                        dr["nama_bibit"].ToString();

                    card.lblStatusPesanan.Text =
                        dr["status_pesanan"].ToString();

                    card.lblTotalBayar.Text =
                        "Rp " + Convert.ToInt32(dr["total_bayar"]).ToString("N0");

                    flpRiwayat.Controls.Add(card);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public FormRiwayatPembelian()
        {
            InitializeComponent();
        }

        private void FormRiwayatPembelian_Load(object sender, EventArgs e)
        {
            lblInfoAwal.Visible = true;
            LoadRiwayat();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblNamaBibit_Click(object sender, EventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Owner.Show();

            this.Close();
        }
        private void Card_Click(object sender, EventArgs e)
        {
            UcRiwayat card = (UcRiwayat)sender;

            int idTransaksi = Convert.ToInt32(card.Tag);

            LoadDetailTransaksi(idTransaksi);

        }
        private void LoadDetailTransaksi(int idTransaksi)
        {
            lblInfoAwal.Visible = false;

            try
            {
                NpgsqlConnection conn = DBConnection.GetConnection();

                string query = @"
        SELECT
            b.nama_bibit,
            dt.jumlah,
            t.tanggal_transaksi,
            t.total_bayar,
            t.status_pembayaran,
            t.status_pesanan,
            t.estimasi_pengiriman,
            b.gambar
        FROM transaksi t
        JOIN detail_transaksi dt
            ON t.id_transaksi = dt.id_transaksi
        JOIN bibit b
            ON dt.id_bibit = b.id_bibit
        WHERE t.id_transaksi = @id_transaksi";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id_transaksi", idTransaksi);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string gambar = dr["gambar"].ToString();

                    if (!string.IsNullOrEmpty(gambar) &&
                        File.Exists(gambar))
                    {
                        picBibit.Image = Image.FromFile(gambar);
                    }

                    lblNamaBibit.Text =
                        dr["nama_bibit"].ToString();

                    lblJumlah.Text =
                        "x" + dr["jumlah"].ToString();

                    lblTanggal.Text =
                        Convert.ToDateTime(
                        dr["tanggal_transaksi"])
                        .ToString("dd/MM/yyyy");

                    lblTotalBayar.Text =
                        "Rp " +
                        Convert.ToInt32(
                        dr["total_bayar"])
                        .ToString("N0");

                    lblStatusPembayaran.Text =
                        dr["status_pembayaran"].ToString();

                    lblStatusPesanan.Text =
                        dr["status_pesanan"].ToString();

                    lblEstimasi.Text =
                        dr["estimasi_pengiriman"].ToString();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblInfoAwal_Click(object sender, EventArgs e)
        {

        }
    }
}
