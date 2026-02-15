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
    public partial class frmHastaGirisPaneli : Form
    {
        public frmHastaGirisPaneli()
        {
            InitializeComponent();
        }

        sqlbagalantisi conn = new sqlbagalantisi();

        private void frmHastaGirisPaneli_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel_uyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKayıtOl frmKO = new frmKayıtOl();
            frmKO.ShowDialog();

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from TBL_Hastalar where HastaTC=@p1 and HastaSifre=@p2",conn.baglanti());
            cmd.Parameters.AddWithValue("@p1",mskdtxtTcNo.Text);
            cmd.Parameters.AddWithValue("@p2",mskdtxtSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                frmHastaPanel frmHP = new frmHastaPanel();
                frmHP.TC = mskdtxtTcNo.Text;// giriş yaparken tc yi alıp diğer sayfaya taşıdım
                frmHP.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı TC VEYA Şifre!");
            }
            conn.baglanti().Close();
        }
    }
}
