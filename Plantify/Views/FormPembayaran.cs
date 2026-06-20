using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using plantify.Database;

namespace plantify.Views
{
    public partial class FormPembayaran : Form
    {
        public int totalBayar;
        public int idBibit;
        public int jumlah;
        public int idTransaksi;
        private string pathBuktiTransfer = "";
        public int idUser;
        public FormPembayaran()
        {
            InitializeComponent();
        }

        private void FormPembayaran_Load(object sender, EventArgs e)
        {
            lblTotalBayar.Text = "Rp " + totalBayar.ToString();
        }

        private void lblTotalBayar_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadBukti_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picBuktiTransfer.Image = Image.FromFile(openFileDialog1.FileName);

                pathBuktiTransfer = openFileDialog1.FileName;

                btnKonfirmasi.Enabled = true;
            }
        }

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = DBConnection.GetConnection();

                string query = @"
        INSERT INTO transaksi
        (
            id_user,
            total_bayar,
            status_pembayaran,
            status_pesanan,
            bukti_transfer,
            estimasi_pengiriman
        )
        VALUES
        (
            @id_user,
            @total_bayar,
            @status_pembayaran,
            @status_pesanan,
            @bukti_transfer,
            @estimasi_pengiriman
        )
        RETURNING id_transaksi";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id_user", idUser);
                cmd.Parameters.AddWithValue("@total_bayar", totalBayar);
                cmd.Parameters.AddWithValue("@status_pembayaran", "Menunggu Validasi");
                cmd.Parameters.AddWithValue("@status_pesanan", "Menunggu Diproses");
                cmd.Parameters.AddWithValue("@bukti_transfer", pathBuktiTransfer);
                cmd.Parameters.AddWithValue("@estimasi_pengiriman", "-");

                MessageBox.Show("ID User = " + idUser);

                idTransaksi = Convert.ToInt32(cmd.ExecuteScalar());

                string queryDetail = @"
INSERT INTO detail_transaksi
(
    id_transaksi,
    id_bibit,
    jumlah,
    subtotal
)
VALUES
(
    @id_transaksi,
    @id_bibit,
    @jumlah,
    @subtotal
)";

                NpgsqlCommand cmdDetail = new NpgsqlCommand(queryDetail, conn);

                cmdDetail.Parameters.AddWithValue("@id_transaksi", idTransaksi);
                cmdDetail.Parameters.AddWithValue("@id_bibit", idBibit);
                cmdDetail.Parameters.AddWithValue("@jumlah", jumlah);
                cmdDetail.Parameters.AddWithValue("@subtotal", totalBayar);

                cmdDetail.ExecuteNonQuery();

                string queryUpdateStok = @"
UPDATE bibit
SET stok = stok - @jumlah
WHERE id_bibit = @id_bibit";

                NpgsqlCommand cmdUpdateStok =
                    new NpgsqlCommand(queryUpdateStok, conn);

                cmdUpdateStok.Parameters.AddWithValue("@jumlah", jumlah);
                cmdUpdateStok.Parameters.AddWithValue("@id_bibit", idBibit);

                cmdUpdateStok.ExecuteNonQuery();

                MessageBox.Show("ID Transaksi: " + idTransaksi);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show(
                "Pembayaran berhasil dikirim!",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            FormTransaksi transaksi = (FormTransaksi)this.Owner;

            transaksi.FormKatalogAsal.MuatKatalog();

            transaksi.FormKatalogAsal.Show();

            this.Owner.Close();

            this.Close();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}