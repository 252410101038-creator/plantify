using plantify.Views;
using Plantify.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

// Masukkan namespace tambahan jika FormBibit Anda berada di folder berbeda
// contoh: using plantify.Forms; 

namespace plantify.Views
{
    public partial class FormDashboardAdmin : Form
    {
        public FormDashboardAdmin()
        {
            InitializeComponent();
        }

        // Pastikan nama method ini sesuai dengan event 'Click' pada tombol di Designer
        private void btnKelolaKatalog_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Membuat instance dari FormBibit
                FormBibit formBibit = new FormBibit();

                //// 2. Menampilkan FormBibit
                formBibit.Show();

                // 3. (Opsional) Jika ingin menutup dashboard lama agar tidak menumpuk:
                this.Hide();
            }
            catch (Exception ex)
            {
                // Menampilkan pesan error jika ada masalah saat memuat form
                MessageBox.Show("Gagal membuka menu bibit: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormDashboardAdmin_Load(object sender, EventArgs e)
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

        private void btnKelolaTransaksi_Click(object sender, EventArgs e)
        {
            FormKelolaPesanan kelola = new FormKelolaPesanan();

            kelola.Owner = this;

            kelola.Show();

            this.Hide();
        }
    }
}