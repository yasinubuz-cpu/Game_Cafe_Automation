namespace GameCafeAutomation_v2
{
    partial class CustomerForm
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
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.lbl_soyisim = new System.Windows.Forms.Label();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.txt_telefon = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(406, 203);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(526, 32);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(100, 20);
            this.txt_isim.TabIndex = 1;
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(526, 117);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(100, 20);
            this.txt_soyisim.TabIndex = 2;
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Location = new System.Drawing.Point(460, 39);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(25, 13);
            this.lbl_isim.TabIndex = 4;
            this.lbl_isim.Text = "İsim";
            // 
            // lbl_soyisim
            // 
            this.lbl_soyisim.AutoSize = true;
            this.lbl_soyisim.Location = new System.Drawing.Point(443, 117);
            this.lbl_soyisim.Name = "lbl_soyisim";
            this.lbl_soyisim.Size = new System.Drawing.Size(42, 13);
            this.lbl_soyisim.TabIndex = 5;
            this.lbl_soyisim.Text = "Soyisim";
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Location = new System.Drawing.Point(443, 195);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(43, 13);
            this.lbl_telefon.TabIndex = 6;
            this.lbl_telefon.Text = "Telefon";
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(22, 303);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(169, 54);
            this.btn_listele.TabIndex = 7;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(216, 303);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(169, 54);
            this.btn_ekle.TabIndex = 8;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(412, 303);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(169, 54);
            this.btn_guncelle.TabIndex = 9;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(606, 303);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(169, 54);
            this.btn_sil.TabIndex = 10;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(526, 188);
            this.txt_telefon.Mask = "(999) 000-0000";
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(100, 20);
            this.txt_telefon.TabIndex = 11;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.lbl_telefon);
            this.Controls.Add(this.lbl_soyisim);
            this.Controls.Add(this.lbl_isim);
            this.Controls.Add(this.txt_soyisim);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerForm";
            this.Text = "Müşteri Yönetimi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.Label lbl_soyisim;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.MaskedTextBox txt_telefon;
    }
}