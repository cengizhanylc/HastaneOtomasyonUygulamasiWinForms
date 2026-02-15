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
using System.Security.Cryptography.X509Certificates;

namespace Hastane_Proje
{
    public partial class frmDoktorEkle : Form
    {
        public frmDoktorEkle()
        {
            InitializeComponent();
        }

        sqlbagalantisi con = new sqlbagalantisi();

        private void Refresh() // datagridwiew i yenileme işlemi
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_Doktorlar", con.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void frmDoktorEkle_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select BransAd From TBL_Branslar", con.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbBrans.Items.Add(dr[0].ToString());
            }

            Refresh();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into TBL_Doktorlar (DoktorAd, DoktorSoyad, DoktorBrans, DoktorTC, DoktorSifre) values(@p1,@p2,@p3,@p4,@p5)", con.baglanti());
            cmd.Parameters.AddWithValue("@p1",txtAd.Text);
            cmd.Parameters.AddWithValue("@p2",txtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3",cmbBrans.Text);
            cmd.Parameters.AddWithValue("@p4",mskdtxtTC.Text);
            cmd.Parameters.AddWithValue("@p5",txtSifre.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("yeni doktor eklendi");
            Refresh();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update TBL_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p5 where DoktorTC=@p4", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", cmbBrans.Text);
            cmd.Parameters.AddWithValue("@p4", mskdtxtTC.Text);
            cmd.Parameters.AddWithValue("@p5", txtSifre.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("doktor kaydı güncellendi");
            Refresh();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskdtxtTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete * From TBL_Doktor where DoktorTC=@p1", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", mskdtxtTC.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Doktor kaydı silindi.");
            Refresh();
        }
    }
}
