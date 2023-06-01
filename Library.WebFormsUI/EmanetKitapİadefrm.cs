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
    public partial class EmanetKitapİadefrm : Form
    {
        public EmanetKitapİadefrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6R8U44M;Initial Catalog=KutuphaneDb;Integrated Security=True");
        DataSet daset = new DataSet();
        private void EmanetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *  from EmanetKitaplar", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
            baglanti.Close();
        }
        private void EmanetKitapİadefrm_Load(object sender, EventArgs e)
        {
            EmanetListele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)//texbox1
        {
            daset.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where tc like '%"+txtTcAra.Text+"%'",baglanti);
            adtr.Fill(daset,"EmanetKitaplar");
            baglanti.Close();
            if (txtTcAra.Text ==" ")
            {
                daset.Tables["EmanetKitaplar"].Clear();
                EmanetListele();

            }
        }

        private void txtBarkodnoAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where barkodno like '%" + txtBarkodnoAra.Text + "%'", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            baglanti.Close();
            if (txtBarkodnoAra.Text == " ")
            {
                daset.Tables["EmanetKitaplar"].Clear();
                EmanetListele();

            }
        }

        private void button1_Click(object sender, EventArgs e)//teslim al
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from EmanetKitaplar where tc=@tc and barkodno=@barkodno",baglanti);
            komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
            komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut.ExecuteNonQuery();//işlemi onayladık
            SqlCommand komut2 = new SqlCommand("update Kitap set stoksayisi=@stoksayisi+'"+dataGridView1.CurrentRow.Cells["kitapsayisi"].Value.ToString()+"' where barkodno=@barkodno",baglanti);
            komut2.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap/kitaplar iade edildi");
            daset.Tables["EmanetKitaplar"].Clear();
            EmanetListele();

        }
    }
}
