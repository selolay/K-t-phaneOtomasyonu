using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.WebFormsUI
{
    public partial class Grafikfrm : Form
    {
        public Grafikfrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6R8U44M;Initial Catalog=KutuphaneDb;Integrated Security=True");

        private void Grafikfrm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select adsoyad, okukitapsayisi from uye",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())//okunduğu müddetçe
            {
                chart1.Series["Okunan Kitap Sayısı"].Points.AddXY(read["adsoyad"].ToString(), read["okukitapsayisi"]);
            }
            baglanti.Close();
            chart1.Series["Okunan Kitap Sayısı"].Color = Color.Orange;
        }
    }
}
