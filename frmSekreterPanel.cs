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
    public partial class frmSekreterPanel : Form
    {
        public frmSekreterPanel()
        {
            InitializeComponent();
        }
        public string TCno;
        // Randevu listesinden gelen veriler için
        public string id;

        sqlbagalantisi con = new sqlbagalantisi();

        private void frmSekreterPanel_Load(object sender, EventArgs e)
        {
            lblTcNo.Text = TCno;

            // AD SOYAD

            SqlCommand cmd = new SqlCommand("Select SekreterAd, SekreterSoyad From TBL_Sekreterler where SekreterTC=@p1", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", lblTcNo.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0].ToString() + " " + dr[1].ToString();
            }

            // BRANŞLARI DATAGRİDWİEW W AKTARMA

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * From TBL_Branslar", con.baglanti());
            da1.Fill(dt1);
            dataGridViewBranslar.DataSource = dt1;

            // DOKTORLARI LİSTEYE AKTARMA

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'doktorlar', DoktorBrans From TBL_Doktorlar", con.baglanti());
            da2.Fill(dt2);
            dataGridViewDoktorlar.DataSource = dt2;

            // Branşları combobox a aktarma

            SqlCommand cmd2 = new SqlCommand("Select BransAd From TBL_Branslar", con.baglanti());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0].ToString());
            }
        }

        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into TBL_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values(@p1,@p2,@p3,@p4)", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", msktxtTarih.Text);
            cmd.Parameters.AddWithValue("@p2", msktxtSaat.Text);
            cmd.Parameters.AddWithValue("@p3", cmbBrans.Text);
            cmd.Parameters.AddWithValue("@p4", cmbDoktor.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("randevu oluşturuldu");
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();

            // brans seçildikten sonra o bransa uygun doktarları getirme

            SqlCommand cmd = new SqlCommand("Select DoktorAd, DoktorSoyad From TBL_Doktorlar where DoktorBrans=@p1", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbDoktor.Items.Add(dr[0].ToString() + " " + dr[1].ToString());
            }
        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into TBL_Duyurular (Duyuru) values(@p1)", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtDuyurular.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Duyuru oluşturuldu");
        }

        private void btnDoktorPaneli_Click(object sender, EventArgs e)
        {
            frmDoktorEkle frmDE = new frmDoktorEkle();
            frmDE.ShowDialog();
        }

        private void btnBransPaneli_Click(object sender, EventArgs e)
        {
            frmBransEkle frmBE = new frmBransEkle();
            frmBE.ShowDialog();
        }

        private void btnRandevuListe_Click(object sender, EventArgs e)
        {
            // frmRandevuListesi formunu açın
            frmRandevuListesi frmRL = new frmRandevuListesi();
            frmRL.ShowDialog();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            frmDuyurular frmD = new frmDuyurular();
            frmD.ShowDialog();
        }
    }
}
