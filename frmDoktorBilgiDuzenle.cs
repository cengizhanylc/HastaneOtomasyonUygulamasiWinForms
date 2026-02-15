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
    public partial class frmDoktorBilgiDuzenle : Form
    {
        public frmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }

        sqlbagalantisi con = new sqlbagalantisi();
        public string TCno;

        private void frmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskdtxtTcNo.Text = TCno;

            SqlCommand cmd = new SqlCommand("select DoktorAd,DoktorSoyad,DoktorBrans,DoktorSifre From TBL_Doktorlar where DoktorTC=@p1",con.baglanti());
            cmd.Parameters.AddWithValue("@p1",TCno);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtAd.Text = dr[0].ToString();
                txtSoyAd.Text = dr[1].ToString();
                cmbBrans.Text = dr[2].ToString();
                txtSifre.Text = dr[3].ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update TBL_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2, DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtSoyAd.Text);
            cmd.Parameters.AddWithValue("@p3", cmbBrans.Text);
            cmd.Parameters.AddWithValue("@p4", txtSifre.Text);
            cmd.Parameters.AddWithValue("@p5", mskdtxtTcNo.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Bilgileriniz güncellendi.");
        }
    }
}
