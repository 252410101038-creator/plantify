using Npgsql;
using plantify.Database;
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using plantify.Views;

namespace Plantify.Views
{
    public partial class FormKelolaPesanan : Form
    {
        private int idTransaksiDipilih;
        public FormKelolaPesanan()
        {
            InitializeComponent();

            lblInfoAwal.Visible = true;

            LoadPesanan();
        }

        private void LoadPesanan()
        {
            try
            {
                NpgsqlConnection conn =
                    DBConnection.GetConnection();

                string query = @"
SELECT
    id_transaksi,
    status_pesanan
FROM transaksi
ORDER BY tanggal_transaksi DESC";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(query, conn);

                NpgsqlDataReader dr =
                    cmd.ExecuteReader();

                flpPesanan.Controls.Clear();

                while (dr.Read())
                {
                    UcPesanan card =
                        new UcPesanan();

                    card.Tag =
                        Convert.ToInt32(
                            dr["id_transaksi"]);

                    card.lblIdTransaksi.Text =
                        "#" +
                        dr["id_transaksi"].ToString();

                    card.lblStatusPesanan.Text =
                        dr["status_pesanan"].ToString();

                    card.Click += Card_Click;

                    card.lblIdTransaksi.Click += Card_Click;
                    card.lblStatusPesanan.Click += Card_Click;

                    flpPesanan.Controls.Add(card);
                }

                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Card_Click(
            object sender,
            EventArgs e)
        {
            Control control = sender as Control;

            UcPesanan card;

            if (control is UcPesanan)
            {
                card = (UcPesanan)control;
            }
            else
            {
                card = (UcPesanan)control.Parent;
            }

            int idTransaksi =
                Convert.ToInt32(card.Tag);

            idTransaksiDipilih = idTransaksi;

            LoadDetailPesanan(idTransaksi);
        }
        private void LoadDetailPesanan(int idTransaksi)
        {
            lblInfoAwal.Visible = false;

            try
            {
                NpgsqlConnection conn = DBConnection.GetConnection();

                string query = @"
SELECT
    u.nama_user,
    u.no_telepon,
    u.alamat,

    b.nama_bibit,
    b.gambar,

    dt.jumlah,

    t.tanggal_transaksi,
    t.total_bayar,
    t.status_pembayaran,
    t.status_pesanan,
    t.estimasi_pengiriman,
    t.bukti_transfer

FROM transaksi t

JOIN users u
ON t.id_user = u.id_user

JOIN detail_transaksi dt
ON t.id_transaksi = dt.id_transaksi

JOIN bibit b
ON dt.id_bibit = b.id_bibit

WHERE t.id_transaksi = @id_transaksi";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue(
                    "@id_transaksi",
                    idTransaksi);

                NpgsqlDataReader dr =
                    cmd.ExecuteReader();

                if (dr.Read())
                {
                    lblNamaCustomer.Text =
                        dr["nama_user"].ToString();

                    lblNoTelepon.Text =
                        dr["no_telepon"].ToString();

                    lblAlamat.Text =
                        dr["alamat"].ToString();

                    lblNamaBibit.Text =
                        dr["nama_bibit"].ToString();

                    lblJumlah.Text =
                        dr["jumlah"].ToString();

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

                    string gambarBibit =
                        dr["gambar"].ToString();

                    if (!string.IsNullOrEmpty(gambarBibit)
                        && File.Exists(gambarBibit))
                    {
                        picBibit.Image =
                            Image.FromFile(gambarBibit);
                    }

                    string buktiTransfer =
                        dr["bukti_transfer"].ToString();

                    if (!string.IsNullOrEmpty(buktiTransfer)
                        && File.Exists(buktiTransfer))
                    {
                        picBuktiTransfer.Image =
                            Image.FromFile(buktiTransfer);
                    }

                    AturTombol(
                        dr["status_pesanan"].ToString());
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AturTombol(string status)
        {
            if (status == "Menunggu Diproses")
            {
                btnTerima.Visible = true;
                btnTolak.Visible = true;

                btnTerima.Text = "Terima";
            }
            else if (status == "Diproses")
            {
                btnTerima.Visible = true;
                btnTolak.Visible = false;

                btnTerima.Text = "Kirim Pesanan";
            }
            else if (status == "Dikirim")
            {
                btnTerima.Visible = true;
                btnTolak.Visible = false;

                btnTerima.Text = "Selesaikan Pesanan";
            }
            else
            {
                btnTerima.Visible = false;
                btnTolak.Visible = false;
            }
        }

        private void btnKembali_Click(
            object sender,
            EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnTerima_Click(object sender, EventArgs e)
        {
            string status = lblStatusPesanan.Text;

            if (status == "Menunggu Diproses")
            {
                ValidasiPesanan();
            }
            else if (status == "Diproses")
            {
                KirimPesanan();
            }
            else if (status == "Dikirim")
            {
                SelesaikanPesanan();
            }
        }
        private void ValidasiPesanan()
        {
            string estimasi = Interaction.InputBox(
                "Masukkan estimasi pengiriman",
                "Estimasi Pengiriman",
                "");

            if (string.IsNullOrWhiteSpace(estimasi))
                return;

            try
            {
                NpgsqlConnection conn =
                    DBConnection.GetConnection();

                string query = @"
UPDATE transaksi
SET
    status_pembayaran = 'Lunas',
    status_pesanan = 'Diproses',
    estimasi_pengiriman = @estimasi
WHERE id_transaksi = @id";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@estimasi", estimasi);
                cmd.Parameters.AddWithValue("@id", idTransaksiDipilih);

                cmd.ExecuteNonQuery();

                conn.Close();

                LoadDetailPesanan(idTransaksiDipilih);
                LoadPesanan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void KirimPesanan()
        {
            try
            {
                NpgsqlConnection conn =
                    DBConnection.GetConnection();

                string query = @"
UPDATE transaksi
SET status_pesanan = 'Dikirim'
WHERE id_transaksi = @id";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id",
                    idTransaksiDipilih);

                cmd.ExecuteNonQuery();

                conn.Close();

                LoadDetailPesanan(idTransaksiDipilih);
                LoadPesanan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SelesaikanPesanan()
        {
            try
            {
                NpgsqlConnection conn =
                    DBConnection.GetConnection();

                string query = @"
UPDATE transaksi
SET status_pesanan = 'Selesai'
WHERE id_transaksi = @id";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id",
                    idTransaksiDipilih);

                cmd.ExecuteNonQuery();

                conn.Close();

                LoadDetailPesanan(idTransaksiDipilih);
                LoadPesanan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormKelolaPesanan_Load(object sender, EventArgs e)
        {

        }
        private void btnTolak_Click(object sender, EventArgs e)
        {
            DialogResult hasil =
    MessageBox.Show(
        "Yakin ingin menolak pesanan ini?",
        "Konfirmasi",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (hasil != DialogResult.Yes)
                return;

            try
            {
                NpgsqlConnection conn =
                    DBConnection.GetConnection();

                string query = @"
UPDATE transaksi
SET
    status_pembayaran = 'Ditolak',
    status_pesanan = 'Dibatalkan'
WHERE id_transaksi = @id";

                NpgsqlCommand cmd =
                    new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id",
                    idTransaksiDipilih);

                cmd.ExecuteNonQuery();

                conn.Close();

                LoadDetailPesanan(idTransaksiDipilih);
                LoadPesanan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}