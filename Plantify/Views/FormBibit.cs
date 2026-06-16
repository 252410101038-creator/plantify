using Npgsql;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using plantify.Controllers;

namespace plantify.Views
{
    public partial class FormBibit : Form
    {
        int id;
        string imagePath = "";

        public FormBibit()
        {
            InitializeComponent();
        }
        // TAMPIL DATA
        private void TampilData()
        {
            BibitController controller =
                new BibitController();

            dataGridView1.DataSource =
                controller.GetAllBibit();
        }
        // RESET FORM
        private void ResetForm()
        {
            id = 0;
            imagePath = "";

            txtNama.Clear();

            cmbJenis.SelectedIndex = -1;

            txtHarga.Clear();
            txtStok.Clear();
            txtSearch.Clear();

            rtbDeskripsi.Clear();

            pictureBox1.Image = null;

            dataGridView1.ClearSelection();

            txtNama.Focus();
        }
        // FORM LOAD
        private void FormBibit_Load(object sender, EventArgs e)
        {
            TampilData();
        }
        // TAMBAH DATA
        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtNama.Text.Trim().Length < 3)
            {
                MessageBox.Show("Nama bibit minimal 3 karakter!");
                return;
            }

            if (cmbJenis.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih jenis bibit terlebih dahulu!");
                return;
            }

            if (!int.TryParse(txtHarga.Text, out int harga) || harga <= 0)
            {
                MessageBox.Show("Harga harus berupa angka dan lebih dari 0!");
                return;
            }

            if (!int.TryParse(txtStok.Text, out int stok) || stok <= 0)
            {
                MessageBox.Show("Stok harus berupa angka dan lebih dari 0!");
                return;
            }

            if (rtbDeskripsi.Text.Trim().Length < 10)
            {
                MessageBox.Show("Deskripsi minimal 10 karakter!");
                return;
            }

            if (string.IsNullOrWhiteSpace(imagePath))
            {
                MessageBox.Show("Silakan upload gambar terlebih dahulu!");
                return;
            }

            string status = "";

            if (int.Parse(txtStok.Text) < 5)
            {
                status = "Hampir Habis";
            }
            else
            {
                status = "Tersedia";
            }

            BibitController controller = new BibitController();

            controller.TambahBibit(
                txtNama.Text,
                cmbJenis.Text,
                int.Parse(txtHarga.Text),
                int.Parse(txtStok.Text),
                rtbDeskripsi.Text,
                imagePath,
                status
            );

            TampilData();
            ResetForm();
        }
        // EDIT DATA
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtNama.Text == "" ||
                cmbJenis.Text == "" ||
                txtHarga.Text == "" ||
                txtStok.Text == "" ||
                rtbDeskripsi.Text == "" ||
                imagePath == "")
            {
                MessageBox.Show(
                    "Semua data harus diisi, termasuk gambar!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!int.TryParse(txtHarga.Text, out _) ||
                !int.TryParse(txtStok.Text, out _))
            {
                MessageBox.Show("Harga dan stok harus angka");

                return;
            }

            DialogResult hasil = MessageBox.Show(
                                 "Yakin ingin memperbarui data bibit ini?",
                                 "Konfirmasi Edit",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            if (hasil == DialogResult.Yes)
            {
                BibitController controller =
                    new BibitController();

                controller.EditBibit(
                    id,
                    txtNama.Text,
                    cmbJenis.Text,
                    int.Parse(txtHarga.Text),
                    int.Parse(txtStok.Text),
                    rtbDeskripsi.Text,
                    imagePath
                );

                TampilData();

                ResetForm();

                MessageBox.Show(
                    "Data berhasil diperbarui.",
                    "Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        // HAPUS DATA
        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show(
                "Yakin ingin menghapus data?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (hasil == DialogResult.Yes)
            {
                BibitController controller =
                    new BibitController();

                controller.HapusBibit(id);

                TampilData();

                ResetForm();
            }
        }
        // SEARCH
        private void btnSearch_Click(object sender, EventArgs e)
        {
            BibitController controller =
                new BibitController();

            dataGridView1.DataSource =
                controller.SearchBibit(txtSearch.Text);
        }
        // RESET BUTTON
        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show(
        "Yakin ingin mereset form?",
        "Konfirmasi Reset",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (hasil == DialogResult.Yes)
            {
                ResetForm();
                TampilData();

                MessageBox.Show(
                    "Form berhasil direset.",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        // KLIK DATAGRIDVIEW
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            txtNama.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            cmbJenis.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            rtbDeskripsi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            txtHarga.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            txtStok.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            imagePath = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
            else
            {
                pictureBox1.Image = null;
            }
        }
        // UPLOAD GAMBAR
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePath = ofd.FileName;

                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void txtStok_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtHarga_TextChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormDashboardAdmin dashboard = new FormDashboardAdmin();
            dashboard.Show();
            this.Close();
        }
    }
}