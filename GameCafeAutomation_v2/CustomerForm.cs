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
    public partial class CustomerForm : Form
    {
        GameCafeDbContext db = new GameCafeDbContext();

        public CustomerForm()
        {
            InitializeComponent();
            btn_listele.PerformClick();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = db.Customers.ToList();
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
                Customer c = new Customer();
                c.Customer_name = txt_isim.Text;
                c.Customer_surname = txt_soyisim.Text;
                c.Cusomer_phone = txt_telefon.Text;
                db.Customers.Add(c);
                db.SaveChanges();
                MessageBox.Show("Kayıt Eklendi!");
                btn_listele.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme hatası: " + ex.Message);
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
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Customer_id"].Value);
                Customer c = db.Customers.Find(id);
                if (c != null)
                {
                    db.Customers.Remove(c);
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

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    int selectedId = Convert.ToInt32(
                        dataGridView1.CurrentRow.Cells["Customer_id"].Value);
                    Customer customer = db.Customers.Find(selectedId);
                    if (customer != null)
                    {
                        customer.Customer_name = txt_isim.Text;
                        customer.Customer_surname = txt_soyisim.Text;
                        customer.Cusomer_phone = txt_telefon.Text;
                        db.SaveChanges();
                        MessageBox.Show("Kayıt Güncellendi!");
                        btn_listele.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_isim.Text = dataGridView1.Rows[e.RowIndex].Cells["Customer_name"].Value.ToString();
                txt_soyisim.Text = dataGridView1.Rows[e.RowIndex].Cells["Customer_surname"].Value.ToString();
                txt_telefon.Text = dataGridView1.Rows[e.RowIndex].Cells["Cusomer_phone"].Value.ToString();
            }
        }
    }
}
