using GameCafeAutomation.Data;
using GameCafeAutomation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCafeAutomation_v2
{
    public partial class GameForm : Form
    {
        GameCafeDbContext db = new GameCafeDbContext();

        public GameForm()
        {
            InitializeComponent();
            btn_listele.PerformClick();

        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            try { dataGridView1.DataSource = db.Games.ToList();
                dataGridView1.Columns["game_id"].Visible = false;
                dataGridView1.Columns["game_name"].HeaderText = "Oyun Adı";
                dataGridView1.Columns["game_category"].HeaderText = "Kategori";
                dataGridView1.Columns["hourly_price"].HeaderText = "Saatlik Ücret";
                dataGridView1.Columns["sessions"].HeaderText = "Oturumlar";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme: " + ex.Message);
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                Game g = new Game();
                g.Game_name = txt_isim.Text;
                g.Game_category = txt_kategori.Text;
                g.Hourly_price = txt_ucret.Text;
                db.Games.Add(g);
                db.SaveChanges();
                MessageBox.Show("Kayıt Eklendi!");
                btn_listele.PerformClick();
            }
            catch (Exception ex) { MessageBox.Show("Ekleme: " + ex.Message); }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null) return;
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Game_id"].Value);
                Game g = db.Games.Find(id);
                if (g != null)
                {
                    db.Games.Remove(g);
                    db.SaveChanges();
                    MessageBox.Show("Kayıt Silindi!");
                    btn_listele.PerformClick();
                }
            }
            catch (Exception ex) { MessageBox.Show("Silme: " + ex.Message); }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Game_id"].Value);
                    Game g = db.Games.Find(id);
                    if (g != null)
                    {
                        g.Game_name = txt_isim.Text;
                        g.Game_category = txt_kategori.Text;
                        g.Hourly_price = txt_ucret.Text;
                        db.SaveChanges();
                        MessageBox.Show("Kayıt Güncellendi!");
                        btn_listele.PerformClick();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Güncelleme: " + ex.Message); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_isim.Text = dataGridView1.Rows[e.RowIndex].Cells["Game_name"].Value.ToString();
                txt_kategori.Text = dataGridView1.Rows[e.RowIndex].Cells["Game_category"].Value.ToString();
                txt_ucret.Text = dataGridView1.Rows[e.RowIndex].Cells["Hourly_price"].Value.ToString();
            }
        }
    }
    
}
   


