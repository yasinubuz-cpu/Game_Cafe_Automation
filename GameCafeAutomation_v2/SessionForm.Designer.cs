namespace GameCafeAutomation_v2
{
    partial class SessionForm
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
            this.lbl_musteri = new System.Windows.Forms.Label();
            this.cmb_customer = new System.Windows.Forms.ComboBox();
            this.lbl_pc = new System.Windows.Forms.Label();
            this.cmb_computer = new System.Windows.Forms.ComboBox();
            this.lbl_game = new System.Windows.Forms.Label();
            this.cmb_game = new System.Windows.Forms.ComboBox();
            this.lb_baslangicl = new System.Windows.Forms.Label();
            this.lbl_bitis = new System.Windows.Forms.Label();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_musteri
            // 
            this.lbl_musteri.AutoSize = true;
            this.lbl_musteri.Location = new System.Drawing.Point(12, 63);
            this.lbl_musteri.Name = "lbl_musteri";
            this.lbl_musteri.Size = new System.Drawing.Size(41, 13);
            this.lbl_musteri.TabIndex = 0;
            this.lbl_musteri.Text = "Müşteri";
            // 
            // cmb_customer
            // 
            this.cmb_customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_customer.FormattingEnabled = true;
            this.cmb_customer.Location = new System.Drawing.Point(70, 60);
            this.cmb_customer.Name = "cmb_customer";
            this.cmb_customer.Size = new System.Drawing.Size(121, 21);
            this.cmb_customer.TabIndex = 1;
            // 
            // lbl_pc
            // 
            this.lbl_pc.AutoSize = true;
            this.lbl_pc.Location = new System.Drawing.Point(248, 68);
            this.lbl_pc.Name = "lbl_pc";
            this.lbl_pc.Size = new System.Drawing.Size(51, 13);
            this.lbl_pc.TabIndex = 2;
            this.lbl_pc.Text = "Bilgisayar";
            // 
            // cmb_computer
            // 
            this.cmb_computer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_computer.FormattingEnabled = true;
            this.cmb_computer.Location = new System.Drawing.Point(336, 65);
            this.cmb_computer.Name = "cmb_computer";
            this.cmb_computer.Size = new System.Drawing.Size(121, 21);
            this.cmb_computer.TabIndex = 3;
            // 
            // lbl_game
            // 
            this.lbl_game.AutoSize = true;
            this.lbl_game.Location = new System.Drawing.Point(511, 68);
            this.lbl_game.Name = "lbl_game";
            this.lbl_game.Size = new System.Drawing.Size(32, 13);
            this.lbl_game.TabIndex = 4;
            this.lbl_game.Text = "Oyun";
            // 
            // cmb_game
            // 
            this.cmb_game.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_game.FormattingEnabled = true;
            this.cmb_game.Location = new System.Drawing.Point(563, 65);
            this.cmb_game.Name = "cmb_game";
            this.cmb_game.Size = new System.Drawing.Size(121, 21);
            this.cmb_game.TabIndex = 5;
            // 
            // lb_baslangicl
            // 
            this.lb_baslangicl.AutoSize = true;
            this.lb_baslangicl.Location = new System.Drawing.Point(12, 134);
            this.lb_baslangicl.Name = "lb_baslangicl";
            this.lb_baslangicl.Size = new System.Drawing.Size(53, 13);
            this.lb_baslangicl.TabIndex = 6;
            this.lb_baslangicl.Text = "Başlangıç";
            // 
            // lbl_bitis
            // 
            this.lbl_bitis.AutoSize = true;
            this.lbl_bitis.Location = new System.Drawing.Point(27, 170);
            this.lbl_bitis.Name = "lbl_bitis";
            this.lbl_bitis.Size = new System.Drawing.Size(26, 13);
            this.lbl_bitis.TabIndex = 7;
            this.lbl_bitis.Text = "Bitiş";
            // 
            // dtp_start
            // 
            this.dtp_start.CustomFormat = "dd.mm.yyyy";
            this.dtp_start.Location = new System.Drawing.Point(99, 128);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(200, 20);
            this.dtp_start.TabIndex = 8;
            // 
            // dtp_end
            // 
            this.dtp_end.CustomFormat = "dd.mm.yyyy";
            this.dtp_end.Location = new System.Drawing.Point(99, 164);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(200, 20);
            this.dtp_end.TabIndex = 9;
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(48, 320);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(143, 47);
            this.btn_listele.TabIndex = 10;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(239, 320);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(143, 47);
            this.btn_ekle.TabIndex = 11;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(430, 320);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(143, 47);
            this.btn_guncelle.TabIndex = 12;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(620, 320);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(143, 47);
            this.btn_sil.TabIndex = 13;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(365, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 186);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.dtp_start);
            this.Controls.Add(this.lbl_bitis);
            this.Controls.Add(this.lb_baslangicl);
            this.Controls.Add(this.cmb_game);
            this.Controls.Add(this.lbl_game);
            this.Controls.Add(this.cmb_computer);
            this.Controls.Add(this.lbl_pc);
            this.Controls.Add(this.cmb_customer);
            this.Controls.Add(this.lbl_musteri);
            this.Name = "SessionForm";
            this.Text = "Oturum Yönetimi";
            this.Load += new System.EventHandler(this.SessionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_musteri;
        private System.Windows.Forms.ComboBox cmb_customer;
        private System.Windows.Forms.Label lbl_pc;
        private System.Windows.Forms.ComboBox cmb_computer;
        private System.Windows.Forms.Label lbl_game;
        private System.Windows.Forms.ComboBox cmb_game;
        private System.Windows.Forms.Label lb_baslangicl;
        private System.Windows.Forms.Label lbl_bitis;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}