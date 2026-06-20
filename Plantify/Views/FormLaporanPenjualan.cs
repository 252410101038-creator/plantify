using Npgsql;
using plantify.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Plantify.Views
{
    public partial class FormLaporanPenjualan : Form
    {
        private Chart chartTransaksi;
        public FormLaporanPenjualan()
        {
            InitializeComponent();

            BuatChart();
        }
        private void BuatChart()
        {
            chartTransaksi = new Chart();

            ChartArea area = new ChartArea();
            chartTransaksi.ChartAreas.Add(area);

            chartTransaksi.Dock = DockStyle.Fill;

            panel1.Controls.Add(chartTransaksi);
        }

        private void FormLaporanPenjualan_Load(object sender, EventArgs e)
        {
            cmbBulan.Items.Add("Januari");
            cmbBulan.Items.Add("Februari");
            cmbBulan.Items.Add("Maret");
            cmbBulan.Items.Add("April");
            cmbBulan.Items.Add("Mei");
            cmbBulan.Items.Add("Juni");
            cmbBulan.Items.Add("Juli");
            cmbBulan.Items.Add("Agustus");
            cmbBulan.Items.Add("September");
            cmbBulan.Items.Add("Oktober");
            cmbBulan.Items.Add("November");
            cmbBulan.Items.Add("Desember");


            for (int tahun = 2025; tahun <= 2030; tahun++)
            {
                cmbTahun.Items.Add(tahun);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Owner.Show();

            this.Close();
        }

        private void cmbBulan_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLaporan();
        }

        private void cmbTahun_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLaporan();
        }
        private void LoadLaporan()
        {
            if (cmbBulan.SelectedIndex == -1 ||
                cmbTahun.SelectedIndex == -1)
            {
                return;
            }

            try
            {
                NpgsqlConnection conn = DBConnection.GetConnection();

                int bulan = cmbBulan.SelectedIndex + 1;
                int tahun = Convert.ToInt32(cmbTahun.SelectedItem);


                string query = @"
        SELECT COALESCE(SUM(total_bayar),0)
        FROM transaksi
        WHERE EXTRACT(MONTH FROM tanggal_transaksi) = @bulan
        AND EXTRACT(YEAR FROM tanggal_transaksi) = @tahun";


                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@bulan", bulan);
                cmd.Parameters.AddWithValue("@tahun", tahun);


                int total = Convert.ToInt32(cmd.ExecuteScalar());

                lblLaporanPenjualan.Text =
                    "Total Pendapatan : Rp " + total.ToString("N0");

                LoadChart(bulan, tahun);


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void LoadChart(int bulan, int tahun)
        {
            try
            {
                NpgsqlConnection conn = DBConnection.GetConnection();


                string query = @"
        SELECT 
            EXTRACT(DAY FROM tanggal_transaksi) AS tanggal,
            COUNT(id_transaksi) AS jumlah
        FROM transaksi
        WHERE EXTRACT(MONTH FROM tanggal_transaksi) = @bulan
        AND EXTRACT(YEAR FROM tanggal_transaksi) = @tahun
        GROUP BY tanggal
        ORDER BY tanggal";


                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@bulan", bulan);
                cmd.Parameters.AddWithValue("@tahun", tahun);


                NpgsqlDataReader dr = cmd.ExecuteReader();


                chartTransaksi.Series.Clear();


                Series series = new Series("Jumlah Transaksi");

                series.ChartType = SeriesChartType.Column;


                while (dr.Read())
                {
                    series.Points.AddXY(
                        dr["tanggal"].ToString(),
                        Convert.ToInt32(dr["jumlah"])
                    );
                }


                chartTransaksi.Series.Add(series);

                chartTransaksi.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
                chartTransaksi.ChartAreas[0].AxisX.Title = "Tanggal";
                chartTransaksi.ChartAreas[0].AxisY.Title = "Jumlah Transaksi";


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblJudul_Click(object sender, EventArgs e)
        {

        }

        private void lblLaporanPenjualan_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
