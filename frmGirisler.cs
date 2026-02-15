using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Proje
{
    public partial class frmGirisler : Form
    {
        public frmGirisler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHastaGirisPaneli frmHGP = new frmHastaGirisPaneli();
            frmHGP.ShowDialog();
            this.Close();
        }

        private void btnDoktorGiris_Click(object sender, EventArgs e)
        {
            frmDoktorGiris frmDGP = new frmDoktorGiris();
            frmDGP.ShowDialog();
            this.Close();
        }

        private void btnSekreterGiris_Click(object sender, EventArgs e)
        {
            frmSekreterGiris frmSGP = new frmSekreterGiris();
            frmSGP.ShowDialog();
            this.Close();
        }
    }
}
