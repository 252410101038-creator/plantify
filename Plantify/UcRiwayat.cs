using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Plantify
{
    public partial class UcRiwayat : UserControl
    {
        public UcRiwayat()
        {
            InitializeComponent();

            lblIdTransaksi.Click += UcRiwayat_Click;
            lblNamaBibit.Click += UcRiwayat_Click;
            lblStatusPesanan.Click += UcRiwayat_Click;
            lblTotalBayar.Click += UcRiwayat_Click;
        }
        private void UcRiwayat_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
