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
    public partial class SessionForm : Form
    {
        GameCafeDbContext db = new GameCafeDbContext();

        public SessionForm()
        {
            InitializeComponent();
        }

        private void SessionForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            btn_listele.PerformClick();
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

        private void btn_listele_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = db.Sessions
                    .Select(s => new
                    {
                        s.Session_id,
                        s.Customer_id,
                        s.Computer_id,
                        s.Game_id,
                        s.Start_Time,
                        s.End_Time
                    }).ToList();
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
                Session s = new Session();
                s.Customer_id = (int)cmb_customer.SelectedValue;
                s.Computer_id = (int)cmb_computer.SelectedValue;
                s.Game_id = (int)cmb_game.SelectedValue;
                s.Start_Time = dtp_start.Value;
                s.End_Time = dtp_end.Value;
                db.Sessions.Add(s);
                db.SaveChanges();
                MessageBox.Show("Kayıt Eklendi!");
                btn_listele.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme: " + ex.Message);
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null) return;
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Session_id"].Value);
                Session s = db.Sessions.Find(id);
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
                MessageBox.Show("Silme: " + ex.Message);
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Session_id"].Value);
                    Session s = db.Sessions.Find(id);
                    if (s != null)
                    {
                        s.Customer_id = (int)cmb_customer.SelectedValue;
                        s.Computer_id = (int)cmb_computer.SelectedValue;
                        s.Game_id = (int)cmb_game.SelectedValue;
                        s.Start_Time = dtp_start.Value;
                        s.End_Time = dtp_end.Value;
                        db.SaveChanges();
                        MessageBox.Show("Kayıt Güncellendi!");
                        btn_listele.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells["Customer_id"].Value != DBNull.Value)
                    cmb_customer.SelectedValue = Convert.ToInt32(row.Cells["Customer_id"].Value);
                if (row.Cells["Computer_id"].Value != DBNull.Value)
                    cmb_computer.SelectedValue = Convert.ToInt32(row.Cells["Computer_id"].Value);
                if (row.Cells["Game_id"].Value != DBNull.Value)
                    cmb_game.SelectedValue = Convert.ToInt32(row.Cells["Game_id"].Value);
                if (row.Cells["Start_Time"].Value != DBNull.Value)
                    dtp_start.Value = Convert.ToDateTime(row.Cells["Start_Time"].Value);
                if (row.Cells["End_Time"].Value != DBNull.Value)
                    dtp_end.Value = Convert.ToDateTime(row.Cells["End_Time"].Value);
            }
        }
    }
}
