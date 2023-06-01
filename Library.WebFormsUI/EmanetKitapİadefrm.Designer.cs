namespace Library.WebFormsUI
{
    partial class EmanetKitapİadefrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmanetKitapİadefrm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.txtTcAra = new System.Windows.Forms.TextBox();
            this.txtBarkodnoAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(917, 417);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(654, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Teslim AL";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "girl-teen-abstract-art-wallpaper-preview.jpg");
            this.ımageList1.Images.SetKeyName(1, "325948.jpg");
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(890, 557);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 62);
            this.button2.TabIndex = 2;
            this.button2.Text = "iptal";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTcAra
            // 
            this.txtTcAra.Location = new System.Drawing.Point(391, 50);
            this.txtTcAra.Name = "txtTcAra";
            this.txtTcAra.Size = new System.Drawing.Size(100, 22);
            this.txtTcAra.TabIndex = 3;
            this.txtTcAra.TextChanged += new System.EventHandler(this.txtTcAra_TextChanged);
            // 
            // txtBarkodnoAra
            // 
            this.txtBarkodnoAra.Location = new System.Drawing.Point(809, 53);
            this.txtBarkodnoAra.Name = "txtBarkodnoAra";
            this.txtBarkodnoAra.Size = new System.Drawing.Size(190, 22);
            this.txtBarkodnoAra.TabIndex = 4;
            this.txtBarkodnoAra.TextChanged += new System.EventHandler(this.txtBarkodnoAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tc ye göre ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(675, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "barkod no ya göre";
            // 
            // EmanetKitapİadefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::Library.WebFormsUI.Properties.Resources._0a1aada00584a24b074ad7ab0689e1c41;
            this.ClientSize = new System.Drawing.Size(1159, 734);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarkodnoAra);
            this.Controls.Add(this.txtTcAra);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmanetKitapİadefrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet Kitap İade Sayfası ";
            this.Load += new System.EventHandler(this.EmanetKitapİadefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTcAra;
        private System.Windows.Forms.TextBox txtBarkodnoAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}