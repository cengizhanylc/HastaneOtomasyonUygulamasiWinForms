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
using System.Runtime.Remoting.Messaging;
using System.Data.Common;

namespace Hastane_Proje
{
    public partial class frmHastaPanel : Form
    {
        public frmHastaPanel()
        {
            InitializeComponent();
        }

        public string TC;

        sqlbagalantisi con = new sqlbagalantisi();

        private void frmHastaPanel_Load(object sender, EventArgs e)
        {
                // TCNO AD SOYAD
                lblTcNo.Text = TC;
                lblAdSoyad.Text = " ";
                // SQL sorgusunu oluşturun
                SqlCommand cmd = new SqlCommand("SELECT HastaAd, HastaSoyad FROM TBL_Hastalar WHERE HastaTC = @p1", con.baglanti());
                cmd.Parameters.AddWithValue("@p1", TC); // lblTcNo.Text yerine TC kullanıldı

                // Sorguyu çalıştırın
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    // Veriyi alın ve etikete yazdırılabilir bir formata dönüştürün
                    string adSoyad = dr.GetValue(0).ToString() + " " + dr.GetValue(1).ToString();

                    // Etikete veriyi atayın
                    lblAdSoyad.Text = adSoyad;
                }

                // Randevu geçmişi
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from TBL_Randevular where HastaTC=" + TC, con.baglanti());
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            // Branşları çekme
            SqlCommand cmd2 = new SqlCommand("select BransAd From TBL_Branslar",con.baglanti());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2.GetValue(0).ToString());
            }

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            cmbDoktor.Text = " ";
            SqlCommand cmd3 = new SqlCommand("Select DoktorAd,DoktorSoyad From TBL_Doktorlar Where DoktorBrans=@p1",con.baglanti());
            cmd3.Parameters.AddWithValue("@p1",cmbBrans.Text);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoktor.Items.Add(dr3.GetValue(0).ToString() + " " + dr3.GetValue(1).ToString());
            }
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_Randevular Where RandevuBrans='" + cmbBrans.Text + "' and RandevuDoktor='" + cmbDoktor.Text + "' and RandevuDurum=0",con.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void lnkLblBilgilriniDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBilgiDuzenle frmBD = new frmBilgiDuzenle();
            frmBD.TCno = lblTcNo.Text;
            frmBD.ShowDialog();
            

        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update TBL_Randevular set RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 where Randevuid=@p3 ",con.baglanti());
            cmd.Parameters.AddWithValue("@p1", lblTcNo.Text);
            cmd.Parameters.AddWithValue("@p2", richtxtSikayet.Text);
            cmd.Parameters.AddWithValue("@p3", txtId.Text);
            cmd.ExecuteNonQuery();

            // Randevu geçmişini getirme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_Randevular where HastaTC=" + TC, con.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.baglanti().Close();
            MessageBox.Show("randevu talebiniz alınmıştır.");
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }
    }
}
