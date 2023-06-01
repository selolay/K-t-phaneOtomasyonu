namespace Library.WebFormsUI
{
    partial class KitapListelefrm
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
            this.comboTuru = new System.Windows.Forms.ComboBox();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxTür = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtRafNo = new System.Windows.Forms.TextBox();
            this.txtStokSayisi = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBarkodAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboTuru
            // 
            this.comboTuru.FormattingEnabled = true;
            this.comboTuru.Items.AddRange(new object[] {
            "Çocuk Kitapları",
            "Hikaye",
            "Roman"});
            this.comboTuru.Location = new System.Drawing.Point(134, 378);
            this.comboTuru.Name = "comboTuru";
            this.comboTuru.Size = new System.Drawing.Size(222, 24);
            this.comboTuru.TabIndex = 40;
            // 
            // btnİptal
            // 
            this.btnİptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİptal.Location = new System.Drawing.Point(228, 621);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(128, 54);
            this.btnİptal.TabIndex = 39;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.Location = new System.Drawing.Point(134, 621);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(118, 54);
            this.btnGüncelle.TabIndex = 38;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(42, 564);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Açıklama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(46, 502);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Raf No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(30, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "stok sayısı";
            // 
            // tbxTür
            // 
            this.tbxTür.AutoSize = true;
            this.tbxTür.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxTür.Location = new System.Drawing.Point(76, 382);
            this.tbxTür.Name = "tbxTür";
            this.tbxTür.Size = new System.Drawing.Size(38, 20);
            this.tbxTür.TabIndex = 34;
            this.tbxTür.Text = "türü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(26, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "sayfa sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(46, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "yayınevi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(64, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "yazar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(45, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Kitap adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "K.Barkod No";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(134, 560);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(222, 55);
            this.txtAciklama.TabIndex = 28;
            // 
            // txtRafNo
            // 
            this.txtRafNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRafNo.Location = new System.Drawing.Point(134, 494);
            this.txtRafNo.Name = "txtRafNo";
            this.txtRafNo.Size = new System.Drawing.Size(222, 24);
            this.txtRafNo.TabIndex = 27;
            // 
            // txtStokSayisi
            // 
            this.txtStokSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStokSayisi.Location = new System.Drawing.Point(134, 438);
            this.txtStokSayisi.Name = "txtStokSayisi";
            this.txtStokSayisi.Size = new System.Drawing.Size(222, 24);
            this.txtStokSayisi.TabIndex = 26;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayfaSayisi.Location = new System.Drawing.Point(134, 315);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(222, 24);
            this.txtSayfaSayisi.TabIndex = 25;
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYayinevi.Location = new System.Drawing.Point(134, 254);
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(222, 24);
            this.txtYayinevi.TabIndex = 24;
            // 
            // txtYazar
            // 
            this.txtYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYazar.Location = new System.Drawing.Point(134, 193);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(222, 24);
            this.txtYazar.TabIndex = 23;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAdi.Location = new System.Drawing.Point(134, 135);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(222, 24);
            this.txtKitapAdi.TabIndex = 22;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkodNo.Location = new System.Drawing.Point(134, 79);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(222, 24);
            this.txtBarkodNo.TabIndex = 21;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(375, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(870, 488);
            this.dataGridView1.TabIndex = 41;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(1049, 568);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(196, 40);
            this.btnSil.TabIndex = 42;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(340, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "K.Barkod No Ara";
            // 
            // txtBarkodAra
            // 
            this.txtBarkodAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkodAra.Location = new System.Drawing.Point(495, 35);
            this.txtBarkodAra.Name = "txtBarkodAra";
            this.txtBarkodAra.Size = new System.Drawing.Size(192, 24);
            this.txtBarkodAra.TabIndex = 43;
            this.txtBarkodAra.TextChanged += new System.EventHandler(this.tbxBarkodAra_TextChanged);
            // 
            // KitapListelefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1273, 706);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBarkodAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboTuru);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxTür);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtRafNo);
            this.Controls.Add(this.txtStokSayisi);
            this.Controls.Add(this.txtSayfaSayisi);
            this.Controls.Add(this.txtYayinevi);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.txtBarkodNo);
            this.Name = "KitapListelefrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Listeleme Sayfası";
            this.Load += new System.EventHandler(this.KitapListelefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTuru;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label tbxTür;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtRafNo;
        private System.Windows.Forms.TextBox txtStokSayisi;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBarkodAra;
    }
}