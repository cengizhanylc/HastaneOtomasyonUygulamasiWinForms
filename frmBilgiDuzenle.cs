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
    public partial class frmBilgiDuzenle : Form
    {
        public frmBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string TCno;
        
        sqlbagalantisi con = new sqlbagalantisi();

        private void frmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskdtxtTcNo.Text = TCno;
            SqlCommand cmd = new SqlCommand("SELECT HastaAd, HastaSoyad, HastaTel, HastaCinsiyet, HastaSifre FROM TBL_Hastalar WHERE HastaTC = @p1", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", TCno);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[0].ToString();
                txtSoyAd.Text = dr[1].ToString();
                mskdtxtTel.Text = dr[2].ToString();
                cmbCinsiyet.Text = dr[3].ToString();
                txtSifre.Text = dr[4].ToString();
            }
            con.baglanti().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update TBL_Hastalar set HastaAd=@p2, HastaSoyad=@p3, HastaTel=@p4, HastaCinsiyet=@p5, HastaSifre=@p6 where HastaTC=@p1;", con.baglanti());
            cmd.Parameters.AddWithValue("@p1",mskdtxtTcNo.Text);
            cmd.Parameters.AddWithValue("@p2",txtAd.Text);
            cmd.Parameters.AddWithValue("@p3",txtSoyAd.Text);
            cmd.Parameters.AddWithValue("@p4",mskdtxtTel.Text);
            cmd.Parameters.AddWithValue("@p5",cmbCinsiyet.Text);
            cmd.Parameters.AddWithValue("@p6",txtSifre.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Bilgileriniz güncellendi \n şifreniz= " + txtSifre.Text,"Bilgi",MessageBoxButtons.OKCancel);
        }
    }
}
