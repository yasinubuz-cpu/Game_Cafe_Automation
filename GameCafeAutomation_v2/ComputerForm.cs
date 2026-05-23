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
    public partial class ComputerForm : Form
    {
        GameCafeDbContext db = new GameCafeDbContext();

        public ComputerForm()
        {
            InitializeComponent();
            btn_listele.PerformClick();

        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            try { dataGridView1.DataSource = db.Computers.ToList(); }
            catch (Exception ex) { MessageBox.Show("Listeleme: " + ex.Message); }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                Computer c = new Computer();
                c.Computer_name = txt_isim.Text;
                c.Computer_status = txt_durum.Text;
                db.Computers.Add(c);
                db.SaveChanges();
                MessageBox.Show("Kayıt Eklendi!");
                btn_listele.PerformClick();
            }
            catch (Exception ex) { MessageBox.Show("Ekleme: " + ex.Message); 
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null) return;
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Computer_id"].Value);
                Computer c = db.Computers.Find(id);
                if (c != null)
                {
                    db.Computers.Remove(c);
                    db.SaveChanges();
                    MessageBox.Show("Kayıt Silindi!");
                    btn_listele.PerformClick();
                }
            }
            catch (Exception ex) { MessageBox.Show("Silme: " + ex.Message); 
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Computer_id"].Value);
                    Computer c = db.Computers.Find(id);
                    if (c != null)
                    {
                        c.Computer_name = txt_isim.Text;
                        c.Computer_status = txt_durum.Text;
                        db.SaveChanges();
                        MessageBox.Show("Kayıt Güncellendi!");
                        btn_listele.PerformClick();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Güncelleme: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_isim.Text = dataGridView1.Rows[e.RowIndex].Cells["Computer_name"].Value.ToString();
                txt_durum.Text = dataGridView1.Rows[e.RowIndex].Cells["Computer_status"].Value.ToString();
            }
        }
    }
}
