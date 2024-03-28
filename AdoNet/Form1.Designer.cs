namespace AdoNet
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwTrendyol = new System.Windows.Forms.DataGridView();
            this.lblIsim = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblKalan = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtKalan = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.gbxEkleme = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.gbxguncelleme = new System.Windows.Forms.GroupBox();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.txtIsimGu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKalanGu = new System.Windows.Forms.TextBox();
            this.txtFiyatGu = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTrendyol)).BeginInit();
            this.gbxEkleme.SuspendLayout();
            this.gbxguncelleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwTrendyol
            // 
            this.dgwTrendyol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTrendyol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTrendyol.Location = new System.Drawing.Point(29, 53);
            this.dgwTrendyol.Name = "dgwTrendyol";
            this.dgwTrendyol.RowHeadersWidth = 51;
            this.dgwTrendyol.RowTemplate.Height = 24;
            this.dgwTrendyol.Size = new System.Drawing.Size(1267, 236);
            this.dgwTrendyol.TabIndex = 0;
            this.dgwTrendyol.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwTrendyol_CellClick);
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(53, 30);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(31, 16);
            this.lblIsim.TabIndex = 1;
            this.lblIsim.Text = "isim";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(53, 75);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(31, 16);
            this.lblFiyat.TabIndex = 2;
            this.lblFiyat.Text = "fiyat";
            // 
            // lblKalan
            // 
            this.lblKalan.AutoSize = true;
            this.lblKalan.Location = new System.Drawing.Point(53, 117);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(41, 16);
            this.lblKalan.TabIndex = 3;
            this.lblKalan.Text = "Kalan";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(236, 30);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(100, 22);
            this.txtIsim.TabIndex = 4;
            // 
            // txtKalan
            // 
            this.txtKalan.Location = new System.Drawing.Point(236, 114);
            this.txtKalan.Name = "txtKalan";
            this.txtKalan.Size = new System.Drawing.Size(100, 22);
            this.txtKalan.TabIndex = 5;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(236, 69);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtFiyat.TabIndex = 6;
            // 
            // gbxEkleme
            // 
            this.gbxEkleme.Controls.Add(this.btnEkle);
            this.gbxEkleme.Controls.Add(this.txtIsim);
            this.gbxEkleme.Controls.Add(this.lblIsim);
            this.gbxEkleme.Controls.Add(this.lblFiyat);
            this.gbxEkleme.Controls.Add(this.lblKalan);
            this.gbxEkleme.Controls.Add(this.txtKalan);
            this.gbxEkleme.Controls.Add(this.txtFiyat);
            this.gbxEkleme.Location = new System.Drawing.Point(54, 319);
            this.gbxEkleme.Name = "gbxEkleme";
            this.gbxEkleme.Size = new System.Drawing.Size(365, 175);
            this.gbxEkleme.TabIndex = 7;
            this.gbxEkleme.TabStop = false;
            this.gbxEkleme.Text = "ekleme";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(120, 146);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // gbxguncelleme
            // 
            this.gbxguncelleme.Controls.Add(this.btnguncelle);
            this.gbxguncelleme.Controls.Add(this.txtIsimGu);
            this.gbxguncelleme.Controls.Add(this.label1);
            this.gbxguncelleme.Controls.Add(this.label2);
            this.gbxguncelleme.Controls.Add(this.label3);
            this.gbxguncelleme.Controls.Add(this.txtKalanGu);
            this.gbxguncelleme.Controls.Add(this.txtFiyatGu);
            this.gbxguncelleme.Location = new System.Drawing.Point(806, 319);
            this.gbxguncelleme.Name = "gbxguncelleme";
            this.gbxguncelleme.Size = new System.Drawing.Size(365, 175);
            this.gbxguncelleme.TabIndex = 8;
            this.gbxguncelleme.TabStop = false;
            this.gbxguncelleme.Text = "güncelleme";
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(120, 146);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(75, 23);
            this.btnguncelle.TabIndex = 8;
            this.btnguncelle.Text = "güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // txtIsimGu
            // 
            this.txtIsimGu.Location = new System.Drawing.Point(236, 30);
            this.txtIsimGu.Name = "txtIsimGu";
            this.txtIsimGu.Size = new System.Drawing.Size(100, 22);
            this.txtIsimGu.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "isim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kalan";
            // 
            // txtKalanGu
            // 
            this.txtKalanGu.Location = new System.Drawing.Point(236, 114);
            this.txtKalanGu.Name = "txtKalanGu";
            this.txtKalanGu.Size = new System.Drawing.Size(100, 22);
            this.txtKalanGu.TabIndex = 5;
            // 
            // txtFiyatGu
            // 
            this.txtFiyatGu.Location = new System.Drawing.Point(236, 69);
            this.txtFiyatGu.Name = "txtFiyatGu";
            this.txtFiyatGu.Size = new System.Drawing.Size(100, 22);
            this.txtFiyatGu.TabIndex = 6;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(599, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 506);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.gbxguncelleme);
            this.Controls.Add(this.gbxEkleme);
            this.Controls.Add(this.dgwTrendyol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTrendyol)).EndInit();
            this.gbxEkleme.ResumeLayout(false);
            this.gbxEkleme.PerformLayout();
            this.gbxguncelleme.ResumeLayout(false);
            this.gbxguncelleme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwTrendyol;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblKalan;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.TextBox txtKalan;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.GroupBox gbxEkleme;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox gbxguncelleme;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.TextBox txtIsimGu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKalanGu;
        private System.Windows.Forms.TextBox txtFiyatGu;
        private System.Windows.Forms.Button btnSil;
    }
}

