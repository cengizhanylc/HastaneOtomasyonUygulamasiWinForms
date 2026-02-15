using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Proje
{
    internal class sqlbagalantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8S3J1T5\\SQLEXPRESS;Initial Catalog=Hastane_Proje;Integrated Security=True;Encrypt=False");
            con.Open();
            return con;
        }
    }
}
