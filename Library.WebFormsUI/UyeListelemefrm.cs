﻿using System;
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
    public partial class UyeListelemefrm : Form
    {
        public UyeListelemefrm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();//arama yapar

        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6R8U44M;Initial Catalog=KutuphaneDb;Integrated Security=True");
        private void txtTc_TextChanged(object sender, EventArgs e) //tcyi yazınca hepsi geliyo
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from uye where tc like '"+ txtTc.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();//textlerde kayıtların görünmesini sağlıyo
            while (read.Read())//kayıtlar okuduğu sürece aşağıdaki bilgileri getirir
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtYas.Text = read["yas"].ToString();
                comboCinsiyet.Text = read["cinsiyet"].ToString();
                txtTelefon.Text = read["telefon"].ToString();
                txtAdres.Text = read["adres"].ToString();
                txtEmail.Text = read["email"].ToString();
                txtOkunanSayi.Text = read["okukitapsayisi"].ToString();
            }

            baglanti.Close();
        }

        private DataSet daset = new DataSet();//kayıtları geçici olarak tutacağımız tablo
        private void txtAraTc_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["uye"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from uye where tc like '%"+txtAraTc.Text+"%'",baglanti);
            adtr.Fill(daset,"uye");
            dataGridView1.DataSource = daset.Tables["uye"];
            baglanti.Close();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kaydı silmek mi istiyor musun?","Sil",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {//ayrı da yazılır alltaki kod
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from uye where tc=@tc", baglanti);
                komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme işlemi gerçekleşti");
                daset.Tables["uye"].Clear();//sildikten sonra tabloyu temizledik
                uyelistele();//üyeleri listeledik
                foreach (Control item in Controls)//işlem yapıldıktan sonra tüm textleri temizlesin
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }

            
        }

        private void uyelistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from uye ",baglanti);
            adtr.Fill(daset,"uye");
            dataGridView1.DataSource = daset.Tables["uye"];
            baglanti.Close();
        }
        private void UyeListelemefrm_Load(object sender, EventArgs e)
        {
            uyelistele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update uye set adsoyad=@adsoyad , yas=@yas , cinsiyet=@cinsiyet,telefon=@telefon ,adres=@adres, email=@email, okukitapsayisi=@okukitapsayisi where tc=@tc",baglanti);
            komut.Parameters.AddWithValue("@tc",txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@yas", txtYas.Text);
            komut.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);
            komut.Parameters.AddWithValue("@okukitapsayisi", int.Parse(txtOkunanSayi.Text) );
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi gerçekleşti");
            daset.Tables["uye"].Clear();
            uyelistele();//üyeleri listeledik

            foreach (Control item in Controls)//işlem yapıldıktan sonra tüm textleri temizlesin
            {
                if (item is TextBox) 
                {
                    item.Text = "";
                }
            }

        }
    }
}
