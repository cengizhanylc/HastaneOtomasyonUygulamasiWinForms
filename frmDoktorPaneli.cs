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
    public partial class frmDoktorPaneli : Form
    {
        public frmDoktorPaneli()
        {
            InitializeComponent();
        }

        sqlbagalantisi con = new sqlbagalantisi();
        public string TCno;

        private void frmDoktorPaneli_Load(object sender, EventArgs e)
        {
            lblTcNo.Text = TCno;
            // Doktor AD SOYAD

            SqlCommand cmd = new SqlCommand("select DoktorAd, DoktorSoyad From TBL_Doktorlar where DoktorTC=@p1", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", TCno);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                lblAdSoyad.Text = dr[0].ToString() + " " + dr[1].ToString();
            }
            con.baglanti().Close();

            // Randevular

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * From TBL_Randevular where RandevuDoktor='" + lblAdSoyad.Text +"'", con.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //
        }

        private void btnBilgiDuzenle_Click(object sender, EventArgs e)
        {
            frmDoktorBilgiDuzenle frmDBD = new frmDoktorBilgiDuzenle();
            frmDBD.TCno = lblTcNo.Text;
            frmDBD.ShowDialog();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            frmDuyurular frmD = new frmDuyurular();
            frmD.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchtxtSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
