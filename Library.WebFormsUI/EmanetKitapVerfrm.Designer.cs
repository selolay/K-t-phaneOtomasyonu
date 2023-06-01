namespace Library.WebFormsUI
{
    partial class EmanetKitapVerfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpUyeBilgi = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTcAra = new System.Windows.Forms.TextBox();
            this.grpKitapBilgi = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtKitapSayisi = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtBarkodno = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnTeslimEt = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblKayitliKitapSayi = new System.Windows.Forms.Label();
            this.lblKitapSayi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpUyeBilgi.SuspendLayout();
            this.grpKitapBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(375, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(794, 573);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // grpUyeBilgi
            // 
            this.grpUyeBilgi.Controls.Add(this.label4);
            this.grpUyeBilgi.Controls.Add(this.label3);
            this.grpUyeBilgi.Controls.Add(this.label2);
            this.grpUyeBilgi.Controls.Add(this.label1);
            this.grpUyeBilgi.Controls.Add(this.txtTelefon);
            this.grpUyeBilgi.Controls.Add(this.txtYas);
            this.grpUyeBilgi.Controls.Add(this.txtAdSoyad);
            this.grpUyeBilgi.Controls.Add(this.txtTcAra);
            this.grpUyeBilgi.Location = new System.Drawing.Point(12, 33);
            this.grpUyeBilgi.Name = "grpUyeBilgi";
            this.grpUyeBilgi.Size = new System.Drawing.Size(343, 195);
            this.grpUyeBilgi.TabIndex = 1;
            this.grpUyeBilgi.TabStop = false;
            this.grpUyeBilgi.Text = "Üye Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(29, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(56, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yaş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "TC Ara";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(101, 156);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(203, 22);
            this.txtTelefon.TabIndex = 3;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(101, 113);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(203, 22);
            this.txtYas.TabIndex = 2;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(101, 69);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(203, 22);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtTcAra
            // 
            this.txtTcAra.Location = new System.Drawing.Point(101, 27);
            this.txtTcAra.Name = "txtTcAra";
            this.txtTcAra.Size = new System.Drawing.Size(203, 22);
            this.txtTcAra.TabIndex = 0;
            this.txtTcAra.TextChanged += new System.EventHandler(this.txtTcAra_TextChanged);
            // 
            // grpKitapBilgi
            // 
            this.grpKitapBilgi.Controls.Add(this.label12);
            this.grpKitapBilgi.Controls.Add(this.label11);
            this.grpKitapBilgi.Controls.Add(this.label10);
            this.grpKitapBilgi.Controls.Add(this.label9);
            this.grpKitapBilgi.Controls.Add(this.label8);
            this.grpKitapBilgi.Controls.Add(this.label7);
            this.grpKitapBilgi.Controls.Add(this.label6);
            this.grpKitapBilgi.Controls.Add(this.label5);
            this.grpKitapBilgi.Controls.Add(this.dateTimePicker2);
            this.grpKitapBilgi.Controls.Add(this.dateTimePicker1);
            this.grpKitapBilgi.Controls.Add(this.txtKitapSayisi);
            this.grpKitapBilgi.Controls.Add(this.txtSayfaSayisi);
            this.grpKitapBilgi.Controls.Add(this.txtYayinevi);
            this.grpKitapBilgi.Controls.Add(this.txtYazar);
            this.grpKitapBilgi.Controls.Add(this.txtKitapAdi);
            this.grpKitapBilgi.Controls.Add(this.txtBarkodno);
            this.grpKitapBilgi.Location = new System.Drawing.Point(12, 234);
            this.grpKitapBilgi.Name = "grpKitapBilgi";
            this.grpKitapBilgi.Size = new System.Drawing.Size(343, 391);
            this.grpKitapBilgi.TabIndex = 2;
            this.grpKitapBilgi.TabStop = false;
            this.grpKitapBilgi.Text = "Kitap Bilgileri";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(19, 334);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "iade tarihi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(11, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "teslim tarihi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(9, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Kitap sayısı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(6, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "sayfa sayısı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(25, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Yayınevi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(39, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Yazarı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(24, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kitap Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "BarkodNo";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(111, 335);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(193, 22);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 291);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // txtKitapSayisi
            // 
            this.txtKitapSayisi.Location = new System.Drawing.Point(111, 250);
            this.txtKitapSayisi.Name = "txtKitapSayisi";
            this.txtKitapSayisi.Size = new System.Drawing.Size(193, 22);
            this.txtKitapSayisi.TabIndex = 5;
            this.txtKitapSayisi.Text = "1";
            this.txtKitapSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(111, 204);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(193, 22);
            this.txtSayfaSayisi.TabIndex = 4;
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.Location = new System.Drawing.Point(111, 161);
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(193, 22);
            this.txtYayinevi.TabIndex = 3;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(111, 121);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(193, 22);
            this.txtYazar.TabIndex = 2;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(111, 80);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(193, 22);
            this.txtKitapAdi.TabIndex = 1;
            // 
            // txtBarkodno
            // 
            this.txtBarkodno.Location = new System.Drawing.Point(111, 37);
            this.txtBarkodno.Name = "txtBarkodno";
            this.txtBarkodno.Size = new System.Drawing.Size(193, 22);
            this.txtBarkodno.TabIndex = 0;
            this.txtBarkodno.TextChanged += new System.EventHandler(this.txtBarkodno_TextChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(190, 632);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(126, 28);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(1019, 632);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(150, 46);
            this.btnİptal.TabIndex = 4;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnTeslimEt
            // 
            this.btnTeslimEt.Location = new System.Drawing.Point(841, 632);
            this.btnTeslimEt.Name = "btnTeslimEt";
            this.btnTeslimEt.Size = new System.Drawing.Size(135, 46);
            this.btnTeslimEt.TabIndex = 5;
            this.btnTeslimEt.Text = "Teslim Et";
            this.btnTeslimEt.UseVisualStyleBackColor = true;
            this.btnTeslimEt.Click += new System.EventHandler(this.btnTeslimEt_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(1175, 35);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(88, 47);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblKayitliKitapSayi
            // 
            this.lblKayitliKitapSayi.AutoSize = true;
            this.lblKayitliKitapSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitliKitapSayi.Location = new System.Drawing.Point(393, 632);
            this.lblKayitliKitapSayi.Name = "lblKayitliKitapSayi";
            this.lblKayitliKitapSayi.Size = new System.Drawing.Size(142, 20);
            this.lblKayitliKitapSayi.TabIndex = 7;
            this.lblKayitliKitapSayi.Text = "Kayıtlı kitap sayisi";
            // 
            // lblKitapSayi
            // 
            this.lblKitapSayi.AutoSize = true;
            this.lblKitapSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapSayi.Location = new System.Drawing.Point(587, 632);
            this.lblKitapSayi.Name = "lblKitapSayi";
            this.lblKitapSayi.Size = new System.Drawing.Size(168, 20);
            this.lblKitapSayi.TabIndex = 8;
            this.lblKitapSayi.Text = "Sepetteki kitap Sayısı";
            this.lblKitapSayi.Click += new System.EventHandler(this.lblKitapSayi_Click);
            // 
            // EmanetKitapVerfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1267, 721);
            this.Controls.Add(this.lblKitapSayi);
            this.Controls.Add(this.lblKayitliKitapSayi);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnTeslimEt);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.grpKitapBilgi);
            this.Controls.Add(this.grpUyeBilgi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmanetKitapVerfrm";
            this.Text = "Emanet Kitap Verme Sayfası";
            this.Load += new System.EventHandler(this.EmanetKitapVerfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpUyeBilgi.ResumeLayout(false);
            this.grpUyeBilgi.PerformLayout();
            this.grpKitapBilgi.ResumeLayout(false);
            this.grpKitapBilgi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpUyeBilgi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTcAra;
        private System.Windows.Forms.GroupBox grpKitapBilgi;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtKitapSayisi;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtBarkodno;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnTeslimEt;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblKayitliKitapSayi;
        private System.Windows.Forms.Label lblKitapSayi;
    }
}