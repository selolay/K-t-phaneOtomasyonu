namespace Library.WebFormsUI
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUyeListele = new System.Windows.Forms.Button();
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKitapListele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEmanetİade = new System.Windows.Forms.Button();
            this.btnEmanetListele = new System.Windows.Forms.Button();
            this.btnEmanetVer = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGrafik = new System.Windows.Forms.Button();
            this.btnSıralama = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUyeListele);
            this.groupBox1.Controls.Add(this.btnUyeEkle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(55, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye İşlemler";
            // 
            // btnUyeListele
            // 
            this.btnUyeListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeListele.Location = new System.Drawing.Point(34, 107);
            this.btnUyeListele.Name = "btnUyeListele";
            this.btnUyeListele.Size = new System.Drawing.Size(352, 51);
            this.btnUyeListele.TabIndex = 1;
            this.btnUyeListele.Text = "Üye Listeleme işlemleri";
            this.btnUyeListele.UseVisualStyleBackColor = true;
            this.btnUyeListele.Click += new System.EventHandler(this.btnUyeListele_Click);
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeEkle.Location = new System.Drawing.Point(34, 30);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(352, 48);
            this.btnUyeEkle.TabIndex = 0;
            this.btnUyeEkle.Text = "Üye ekleme işlemleri";
            this.btnUyeEkle.UseVisualStyleBackColor = true;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(44, 30);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(337, 48);
            this.btnKitapEkle.TabIndex = 2;
            this.btnKitapEkle.Text = "Kitap ekleme işlemleri";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKitapListele);
            this.groupBox2.Controls.Add(this.btnKitapEkle);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(649, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap İşlemleri";
            // 
            // btnKitapListele
            // 
            this.btnKitapListele.Location = new System.Drawing.Point(44, 112);
            this.btnKitapListele.Name = "btnKitapListele";
            this.btnKitapListele.Size = new System.Drawing.Size(337, 57);
            this.btnKitapListele.TabIndex = 3;
            this.btnKitapListele.Text = "Kitap Listeleme İşlemleri";
            this.btnKitapListele.UseVisualStyleBackColor = true;
            this.btnKitapListele.Click += new System.EventHandler(this.btnKitapListele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEmanetİade);
            this.groupBox3.Controls.Add(this.btnEmanetListele);
            this.groupBox3.Controls.Add(this.btnEmanetVer);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(55, 378);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(467, 261);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emanet kitap İşlemleri";
            // 
            // btnEmanetİade
            // 
            this.btnEmanetİade.Location = new System.Drawing.Point(23, 187);
            this.btnEmanetİade.Name = "btnEmanetİade";
            this.btnEmanetİade.Size = new System.Drawing.Size(414, 51);
            this.btnEmanetİade.TabIndex = 2;
            this.btnEmanetİade.Text = "Emanet Kitap İade İşlemleri";
            this.btnEmanetİade.UseVisualStyleBackColor = true;
            this.btnEmanetİade.Click += new System.EventHandler(this.btnEmanetİade_Click);
            // 
            // btnEmanetListele
            // 
            this.btnEmanetListele.Location = new System.Drawing.Point(23, 113);
            this.btnEmanetListele.Name = "btnEmanetListele";
            this.btnEmanetListele.Size = new System.Drawing.Size(414, 46);
            this.btnEmanetListele.TabIndex = 1;
            this.btnEmanetListele.Text = "Emanet Listeleme İşlemleri";
            this.btnEmanetListele.UseVisualStyleBackColor = true;
            this.btnEmanetListele.Click += new System.EventHandler(this.btnEmanetListele_Click);
            // 
            // btnEmanetVer
            // 
            this.btnEmanetVer.Location = new System.Drawing.Point(23, 31);
            this.btnEmanetVer.Name = "btnEmanetVer";
            this.btnEmanetVer.Size = new System.Drawing.Size(414, 59);
            this.btnEmanetVer.TabIndex = 0;
            this.btnEmanetVer.Text = "Emanet Kitap Verme İşlemleri";
            this.btnEmanetVer.UseVisualStyleBackColor = true;
            this.btnEmanetVer.Click += new System.EventHandler(this.btnEmanetVer_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.btnGrafik);
            this.groupBox4.Controls.Add(this.btnSıralama);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(649, 378);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(456, 188);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sıralama ve grafikler";
            // 
            // btnGrafik
            // 
            this.btnGrafik.Location = new System.Drawing.Point(44, 119);
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.Size = new System.Drawing.Size(384, 49);
            this.btnGrafik.TabIndex = 1;
            this.btnGrafik.Text = "Grafikler";
            this.btnGrafik.UseVisualStyleBackColor = true;
            this.btnGrafik.Click += new System.EventHandler(this.btnGrafik_Click);
            // 
            // btnSıralama
            // 
            this.btnSıralama.Location = new System.Drawing.Point(44, 45);
            this.btnSıralama.Name = "btnSıralama";
            this.btnSıralama.Size = new System.Drawing.Size(384, 46);
            this.btnSıralama.TabIndex = 0;
            this.btnSıralama.Text = "Sıralama";
            this.btnSıralama.UseVisualStyleBackColor = true;
            this.btnSıralama.Click += new System.EventHandler(this.btnSıralama_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1156, 694);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANA SAYFA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button btnUyeListele;
        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnKitapListele;
        private System.Windows.Forms.Button btnEmanetİade;
        private System.Windows.Forms.Button btnEmanetListele;
        private System.Windows.Forms.Button btnEmanetVer;
        private System.Windows.Forms.Button btnGrafik;
        private System.Windows.Forms.Button btnSıralama;
    }
}

