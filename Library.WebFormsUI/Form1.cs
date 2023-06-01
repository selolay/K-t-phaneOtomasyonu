using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            UyeEklefrm uyeeklefrm = new UyeEklefrm();//anasayfadan üye ekleye bağladık
            uyeeklefrm.ShowDialog();
        }

        private void btnUyeListele_Click(object sender, EventArgs e)
        {
            UyeListelemefrm uyeliste = new UyeListelemefrm();//anasayfadan üye listele bağladık
            uyeliste.ShowDialog();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            KitapEklefrm kitapekle = new KitapEklefrm();
            kitapekle.ShowDialog();
        }

        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            KitapListelefrm kitaplistele = new KitapListelefrm();
            kitaplistele.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEmanetVer_Click(object sender, EventArgs e)
        {
            EmanetKitapVerfrm emanet = new EmanetKitapVerfrm();
            emanet.ShowDialog();
        }

        private void btnEmanetListele_Click(object sender, EventArgs e)
        {
            EmanetKitapListelefrm listele = new EmanetKitapListelefrm();
            listele.ShowDialog();
        }

        private void btnEmanetİade_Click(object sender, EventArgs e)
        {
            EmanetKitapİadefrm iade = new EmanetKitapİadefrm();
            iade.ShowDialog();
        }

        private void btnSıralama_Click(object sender, EventArgs e)
        {
            Sıralamafrm sırala = new Sıralamafrm();
            sırala.ShowDialog();
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            Grafikfrm grafikfrm= new Grafikfrm();
            grafikfrm.ShowDialog();
        }
    }
}
