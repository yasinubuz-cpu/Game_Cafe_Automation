namespace GameCafeAutomation
{
    partial class Anaform
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
            this.btn_musteri = new System.Windows.Forms.Button();
            this.btn_bilgisayar = new System.Windows.Forms.Button();
            this.btn_oyun = new System.Windows.Forms.Button();
            this.btn_oturum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_musteri
            // 
            this.btn_musteri.Location = new System.Drawing.Point(12, 164);
            this.btn_musteri.Name = "btn_musteri";
            this.btn_musteri.Size = new System.Drawing.Size(153, 47);
            this.btn_musteri.TabIndex = 0;
            this.btn_musteri.Text = "Müşteri Yönetimi";
            this.btn_musteri.UseVisualStyleBackColor = true;
            this.btn_musteri.Click += new System.EventHandler(this.btn_musteri_Click);
            // 
            // btn_bilgisayar
            // 
            this.btn_bilgisayar.Location = new System.Drawing.Point(215, 164);
            this.btn_bilgisayar.Name = "btn_bilgisayar";
            this.btn_bilgisayar.Size = new System.Drawing.Size(153, 47);
            this.btn_bilgisayar.TabIndex = 1;
            this.btn_bilgisayar.Text = "Bilgisayar Yönetimi";
            this.btn_bilgisayar.UseVisualStyleBackColor = true;
            this.btn_bilgisayar.Click += new System.EventHandler(this.btn_bilgisayar_Click);
            // 
            // btn_oyun
            // 
            this.btn_oyun.Location = new System.Drawing.Point(419, 164);
            this.btn_oyun.Name = "btn_oyun";
            this.btn_oyun.Size = new System.Drawing.Size(153, 47);
            this.btn_oyun.TabIndex = 2;
            this.btn_oyun.Text = "Oyun Yönetimi";
            this.btn_oyun.UseVisualStyleBackColor = true;
            this.btn_oyun.Click += new System.EventHandler(this.btn_oyun_Click);
            // 
            // btn_oturum
            // 
            this.btn_oturum.Location = new System.Drawing.Point(622, 164);
            this.btn_oturum.Name = "btn_oturum";
            this.btn_oturum.Size = new System.Drawing.Size(153, 47);
            this.btn_oturum.TabIndex = 3;
            this.btn_oturum.Text = "Oturum Yönetimi";
            this.btn_oturum.UseVisualStyleBackColor = true;
            this.btn_oturum.Click += new System.EventHandler(this.btn_oturum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(296, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "CAFE YÖNETİMİ";
            // 
            // Anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_oturum);
            this.Controls.Add(this.btn_oyun);
            this.Controls.Add(this.btn_bilgisayar);
            this.Controls.Add(this.btn_musteri);
            this.Name = "Anaform";
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