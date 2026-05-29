namespace GameCafeAutomation_v2
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.btn_musteri = new System.Windows.Forms.Button();
            this.btn_bilgisayar = new System.Windows.Forms.Button();
            this.btn_oyun = new System.Windows.Forms.Button();
            this.btn_oturum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_musteri
            // 
            this.btn_musteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_musteri.FlatAppearance.BorderSize = 0;
            this.btn_musteri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btn_musteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_musteri.Location = new System.Drawing.Point(29, 194);
            this.btn_musteri.Name = "btn_musteri";
            this.btn_musteri.Size = new System.Drawing.Size(157, 51);
            this.btn_musteri.TabIndex = 0;
            this.btn_musteri.Text = "Müşteri Yönetimi";
            this.btn_musteri.UseVisualStyleBackColor = false;
            this.btn_musteri.Click += new System.EventHandler(this.btn_musteri_Click);
            // 
            // btn_bilgisayar
            // 
            this.btn_bilgisayar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_bilgisayar.FlatAppearance.BorderSize = 0;
            this.btn_bilgisayar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btn_bilgisayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bilgisayar.Location = new System.Drawing.Point(229, 194);
            this.btn_bilgisayar.Name = "btn_bilgisayar";
            this.btn_bilgisayar.Size = new System.Drawing.Size(157, 51);
            this.btn_bilgisayar.TabIndex = 1;
            this.btn_bilgisayar.Text = "Bilgisayar Yönetimi";
            this.btn_bilgisayar.UseVisualStyleBackColor = false;
            this.btn_bilgisayar.Click += new System.EventHandler(this.btn_bilgisayar_Click);
            // 
            // btn_oyun
            // 
            this.btn_oyun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_oyun.FlatAppearance.BorderSize = 0;
            this.btn_oyun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btn_oyun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_oyun.Location = new System.Drawing.Point(422, 194);
            this.btn_oyun.Name = "btn_oyun";
            this.btn_oyun.Size = new System.Drawing.Size(157, 51);
            this.btn_oyun.TabIndex = 2;
            this.btn_oyun.Text = "Oyun Yönetimi";
            this.btn_oyun.UseVisualStyleBackColor = false;
            this.btn_oyun.Click += new System.EventHandler(this.btn_oyun_Click);
            // 
            // btn_oturum
            // 
            this.btn_oturum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_oturum.FlatAppearance.BorderSize = 0;
            this.btn_oturum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btn_oturum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_oturum.Location = new System.Drawing.Point(612, 194);
            this.btn_oturum.Name = "btn_oturum";
            this.btn_oturum.Size = new System.Drawing.Size(157, 51);
            this.btn_oturum.TabIndex = 3;
            this.btn_oturum.Text = "Oturum Yönetimi";
            this.btn_oturum.UseVisualStyleBackColor = false;
            this.btn_oturum.Click += new System.EventHandler(this.btn_oturum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(311, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "CAFE YÖNETİMİ";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_oturum);
            this.Controls.Add(this.btn_oyun);
            this.Controls.Add(this.btn_bilgisayar);
            this.Controls.Add(this.btn_musteri);
            this.Name = "AnaForm";
            this.Text = "Anaform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_musteri;
        private System.Windows.Forms.Button btn_bilgisayar;
        private System.Windows.Forms.Button btn_oyun;
        private System.Windows.Forms.Button btn_oturum;
        private System.Windows.Forms.Label label1;
    }
}

