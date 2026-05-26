using GameCafeAutomation.Data;
using GameCafeAutomation.Models;
using GameCafeAutomation.Data;
using GameCafeAutomation.Models;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace GameCafeAutomation_v2
{
    public partial class SessionForm : Form
    {
        GameCafeDbContext db = new GameCafeDbContext();

        public SessionForm()
        {
            InitializeComponent();
            dtp_start.Format = DateTimePickerFormat.Custom;
            dtp_start.CustomFormat = "dd.MM.yyyy HH:mm";
            dtp_start.ShowUpDown = true;

            dtp_end.Format = DateTimePickerFormat.Custom;
            dtp_end.CustomFormat = "dd.MM.yyyy HH:mm";
            dtp_end.ShowUpDown = true;


            cmb_game.SelectedIndexChanged += (s, e) => HesaplaUcret();
            dtp_start.ValueChanged += (s, e) => HesaplaUcret();
            dtp_end.ValueChanged += (s, e) => HesaplaUcret();
        }

        private void SessionForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            btn_listele.PerformClick();
            HesaplaUcret();
            ToplamTutarAl();
        }

        private void LoadComboBoxes()
        {
            cmb_customer.DataSource = db.Customers.ToList();
            cmb_customer.DisplayMember = "Customer_name";
            cmb_customer.ValueMember = "Customer_id";

            cmb_computer.DataSource = db.Computers.ToList();
            cmb_computer.DisplayMember = "Computer_name";
            cmb_computer.ValueMember = "Computer_id";

            cmb_game.DataSource = db.Games.ToList();
            cmb_game.DisplayMember = "Game_name";
            cmb_game.ValueMember = "Game_id";
        }

        private void HesaplaUcret()
        {
            try
            {
                if (cmb_game.SelectedValue == null)
                {
                    txt_saatlik.Text = "0";
                    txt_toplam.Text = "0,00 TL";
                    return;
                }

                int gameId = Convert.ToInt32(cmb_game.SelectedValue);
                Game oyun = db.Games.Find(gameId);

                if (oyun == null)
                {
                    txt_saatlik.Text = "0";
                    txt_toplam.Text = "0,00 TL";
                    return;
                }

                string ucretStr = (oyun.Hourly_price ?? "0").Trim().Replace(',', '.');
                if (!decimal.TryParse(ucretStr, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal saatlik))
                {
                    txt_saatlik.Text = "Hatalı";
                    txt_toplam.Text = "0,00 TL";
                    return;
                }

                txt_saatlik.Text = saatlik.ToString("N2") + " TL/saat";

                if (dtp_end.Value <= dtp_start.Value)
                {
                    txt_toplam.Text = "0,00 TL";
                    return;
                }

                double saat = (dtp_end.Value - dtp_start.Value).TotalHours;
                decimal toplam = saatlik * (decimal)saat;
                txt_toplam.Text = toplam.ToString("N2") + " TL";
            }
            catch
            {
                txt_saatlik.Text = "0";
                txt_toplam.Text = "0,00 TL";
            }
        }

        private decimal ToplamTutarAl()
        {
            string s = txt_toplam.Text.Replace("TL", "").Trim();
            if (decimal.TryParse(s, NumberStyles.Any, new CultureInfo("tr-TR"), out decimal t))
                return t;
            if (decimal.TryParse(s.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out t))
                return t;
            return 0;
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            try
            {
                LoadComboBoxes();

                dataGridView1.DataSource = db.Sessions
                    .Select(s => new
                    {
                        s.Session_id,
                        Musteri = s.Customer.Customer_name + " " + s.Customer.Customer_surname,
                        Bilgisayar = s.Computer.Computer_name,
                        Oyun = s.Game.Game_name,
                        Baslangic = s.Start_Time,
                        Bitis = s.End_Time,
                        Toplam = s.Total_Price
                    })
                    .ToList();

                if (dataGridView1.Columns["Session_id"] != null)
                    dataGridView1.Columns["Session_id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message);
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtp_end.Value <= dtp_start.Value)
                {
                    MessageBox.Show("Bitiş saati başlangıçtan sonra olmalı.");
                    return;
                }

                HesaplaUcret();
               

                Session s = new Session();
                s.Customer_id = (int)cmb_customer.SelectedValue;
                s.Computer_id = (int)cmb_computer.SelectedValue;
                s.Game_id = (int)cmb_game.SelectedValue;
                s.Start_Time = dtp_start.Value;
                s.End_Time = dtp_end.Value;
                s.Total_Price = ToplamTutarAl();

                db.Sessions.Add(s);
                db.SaveChanges();

                MessageBox.Show("Kayıt Eklendi!\nToplam: " + txt_toplam.Text);
                btn_listele.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme hatası: " + ex.Message);
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Güncellemek için satır seçin.");
                    return;
                }

                if (dtp_end.Value <= dtp_start.Value)
                {
                    MessageBox.Show("Bitiş saati başlangıçtan sonra olmalı.");
                    return;
                }

                HesaplaUcret();
                

                int sessionId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Session_id"].Value);
                Session s = db.Sessions.Find(sessionId);

                if (s != null)
                {
                    s.Customer_id = (int)cmb_customer.SelectedValue;
                    s.Computer_id = (int)cmb_computer.SelectedValue;
                    s.Game_id = (int)cmb_game.SelectedValue;
                    s.Start_Time = dtp_start.Value;
                    s.End_Time = dtp_end.Value;
                    s.Total_Price = ToplamTutarAl();

                    db.SaveChanges();
                    MessageBox.Show("Kayıt Güncellendi!");
                    btn_listele.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message);
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Silmek için satır seçin.");
                    return;
                }

                if (MessageBox.Show("Oturum silinsin mi?", "Onay",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                int sessionId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Session_id"].Value);
                Session s = db.Sessions.Find(sessionId);

                if (s != null)
                {
                    db.Sessions.Remove(s);
                    db.SaveChanges();
                    MessageBox.Show("Kayıt Silindi!");
                    btn_listele.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int sessionId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Session_id"].Value);
            Session s = db.Sessions.Find(sessionId);
            if (s == null) return;

            if (s.Customer_id.HasValue)
                cmb_customer.SelectedValue = s.Customer_id.Value;

            if (s.Computer_id.HasValue)
                cmb_computer.SelectedValue = s.Computer_id.Value;

            if (s.Game_id.HasValue)
                cmb_game.SelectedValue = s.Game_id.Value;

            if (s.Start_Time.HasValue)
                dtp_start.Value = s.Start_Time.Value;

            if (s.End_Time.HasValue)
                dtp_end.Value = s.End_Time.Value;

            HesaplaUcret();
        }
    }
}