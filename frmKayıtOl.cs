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
    public partial class frmKayıtOl : Form
    {
        public frmKayıtOl()
        {
            InitializeComponent();
        }

        sqlbagalantisi con = new sqlbagalantisi();

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into TBL_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTel,HastaCinsiyet,HastaSifre)" +
            "values(@HastaAd,@HastaSoyad,@HastaTC,@HastaTel,@HastaCinsiyet,@HastaSifre)",con.baglanti());
            cmd.Parameters.AddWithValue("@HastaAd",txtAd.Text);
            cmd.Parameters.AddWithValue("@HastaSoyad",txtSoyAd.Text);
            cmd.Parameters.AddWithValue("@HastaTC",mskdtxtTcNo.Text);
            cmd.Parameters.AddWithValue("@HastaTel",mskdtxtTel.Text);
            cmd.Parameters.AddWithValue("@HastaCinsiyet",cmbCinsiyet.Text);
            cmd.Parameters.AddWithValue("@HastaSifre",txtSifre.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("kaydınız gerçekleşmiştir. şifreniz : " + txtSifre.Text,"bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void frmKayıtOl_Load(object sender, EventArgs e)
        {

        }
    }
}
