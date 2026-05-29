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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lbl_saatlik = new System.Windows.Forms.Label();
            this.lbl_toplam = new System.Windows.Forms.Label();
            this.txt_saatlik = new System.Windows.Forms.TextBox();
            this.txt_toplam = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_musteri
            // 
            this.lbl_musteri.AutoSize = true;
            this.lbl_musteri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.lbl_pc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.lbl_game.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.lb_baslangicl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb_baslangicl.Location = new System.Drawing.Point(12, 134);
            this.lb_baslangicl.Name = "lb_baslangicl";
            this.lb_baslangicl.Size = new System.Drawing.Size(53, 13);
            this.lb_baslangicl.TabIndex = 6;
            this.lb_baslangicl.Text = "Başlangıç";
            // 
            // lbl_bitis
            // 
            this.lbl_bitis.AutoSize = true;
            this.lbl_bitis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_bitis.Location = new System.Drawing.Point(27, 170);
            this.lbl_bitis.Name = "lbl_bitis";
            this.lbl_bitis.Size = new System.Drawing.Size(26, 13);
            this.lbl_bitis.TabIndex = 7;
            this.lbl_bitis.Text = "Bitiş";
            // 
            // dtp_start
            // 
            this.dtp_start.CustomFormat = "dd.MM.yyyy  HH:mm";
            this.dtp_start.Location = new System.Drawing.Point(99, 128);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.ShowUpDown = true;
            this.dtp_start.Size = new System.Drawing.Size(200, 20);
            this.dtp_start.TabIndex = 8;
            // 
            // dtp_end
            // 
            this.dtp_end.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtp_end.Location = new System.Drawing.Point(99, 164);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.ShowUpDown = true;
            this.dtp_end.Size = new System.Drawing.Size(200, 20);
            this.dtp_end.TabIndex = 9;
            // 
            // btn_listele
            // 
            this.btn_listele.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.btn_listele.FlatAppearance.BorderSize = 2;
            this.btn_listele.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.btn_listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.btn_listele.Location = new System.Drawing.Point(12, 292);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(143, 47);
            this.btn_listele.TabIndex = 10;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.btn_ekle.FlatAppearance.BorderSize = 2;
            this.btn_ekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.btn_ekle.Location = new System.Drawing.Point(169, 292);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(143, 47);
            this.btn_ekle.TabIndex = 11;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.btn_guncelle.FlatAppearance.BorderSize = 2;
            this.btn_guncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.btn_guncelle.Location = new System.Drawing.Point(12, 361);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(143, 47);
            this.btn_guncelle.TabIndex = 12;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.btn_sil.FlatAppearance.BorderSize = 2;
            this.btn_sil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.btn_sil.Location = new System.Drawing.Point(169, 361);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(143, 47);
            this.btn_sil.TabIndex = 13;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.dataGridView1.Location = new System.Drawing.Point(336, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(461, 347);
            this.dataGridView1.TabIndex = 14;
            // 
            // lbl_saatlik
            // 
            this.lbl_saatlik.AutoSize = true;
            this.lbl_saatlik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_saatlik.Location = new System.Drawing.Point(18, 208);
            this.lbl_saatlik.Name = "lbl_saatlik";
            this.lbl_saatlik.Size = new System.Drawing.Size(68, 13);
            this.lbl_saatlik.TabIndex = 15;
            this.lbl_saatlik.Text = "Saatlik Ücret";
            // 
            // lbl_toplam
            // 
            this.lbl_toplam.AutoSize = true;
            this.lbl_toplam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_toplam.Location = new System.Drawing.Point(18, 245);
            this.lbl_toplam.Name = "lbl_toplam";
            this.lbl_toplam.Size = new System.Drawing.Size(71, 13);
            this.lbl_toplam.TabIndex = 16;
            this.lbl_toplam.Text = "Toplam Ücret";
            // 
            // txt_saatlik
            // 
            this.txt_saatlik.Location = new System.Drawing.Point(99, 201);
            this.txt_saatlik.Name = "txt_saatlik";
            this.txt_saatlik.ReadOnly = true;
            this.txt_saatlik.Size = new System.Drawing.Size(100, 20);
            this.txt_saatlik.TabIndex = 17;
            // 
            // txt_toplam
            // 
            this.txt_toplam.Location = new System.Drawing.Point(99, 238);
            this.txt_toplam.Name = "txt_toplam";
            this.txt_toplam.ReadOnly = true;
            this.txt_toplam.Size = new System.Drawing.Size(100, 20);
            this.txt_toplam.TabIndex = 18;
            // 
            // SessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_toplam);
            this.Controls.Add(this.txt_saatlik);
            this.Controls.Add(this.lbl_toplam);
            this.Controls.Add(this.lbl_saatlik);
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
        private System.Windows.Forms.Label lbl_saatlik;
        private System.Windows.Forms.Label lbl_toplam;
        private System.Windows.Forms.TextBox txt_saatlik;
        private System.Windows.Forms.TextBox txt_toplam;
    }
}