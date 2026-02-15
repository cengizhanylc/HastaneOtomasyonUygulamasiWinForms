using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Proje
{
    public partial class frmDoktorGiris : Form
    {
        public frmDoktorGiris()
        {
            InitializeComponent();
        }
        sqlbagalantisi con = new sqlbagalantisi();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * From TBL_Doktorlar where DoktorTC=@p1 and DoktorSifre=@p2", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", mskdtxtTcNo.Text);
            cmd.Parameters.AddWithValue("@p2", mskdtxtSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                frmDoktorPaneli frmDP = new frmDoktorPaneli();
                frmDP.TCno = mskdtxtTcNo.Text;
                frmDP.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı TC veya Şifre");
            }
            con.baglanti().Close();
        }

        private void frmDoktorGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
