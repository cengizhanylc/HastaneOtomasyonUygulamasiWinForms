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
    public partial class frmBransEkle : Form
    {
        public frmBransEkle()
        {
            InitializeComponent();
        }

        sqlbagalantisi con = new sqlbagalantisi();

        public void Listele() // DATAGRİDWİEW İ YENİLEME VE LİSTELEME
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * From TBL_Branslar", con.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void frmBransEkle_Load(object sender, EventArgs e)
        {
            // BRANŞLARI LİSTELE
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into TBL_Branslar (BransAd) values(@p1)", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Branş eklendi","bilgi",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete From TBL_Branslar Where BransAd=@p1", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("branş silindi.");
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update TBL_Branslar set BransAd=@p1 where Bransid=@p2", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtid.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("branş güncellendi");
            Listele();
        }
    }
}
