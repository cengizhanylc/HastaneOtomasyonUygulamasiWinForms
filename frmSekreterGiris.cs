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
    public partial class frmSekreterGiris : Form
    {
        public frmSekreterGiris()
        {
            InitializeComponent();
        }

        sqlbagalantisi con = new sqlbagalantisi();

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From TBL_Sekreterler where SekreterTC = @p1 and SekreterSifre = @p2",con.baglanti());
            cmd.Parameters.AddWithValue("@p1", mskdtxtTcNo.Text);
            cmd.Parameters.AddWithValue("@p2", mskdtxtSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read()) { 
                frmSekreterPanel frmSP = new frmSekreterPanel();
                frmSP.TCno = mskdtxtTcNo.Text;
                frmSP.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı şifre yada tc.");
                con.baglanti().Close();
            }
        }
    }
}
