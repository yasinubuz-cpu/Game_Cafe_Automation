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
    public partial class frm_anaform : Form
    {
        public frm_anaform()
        {
            InitializeComponent();
        }

        private void btn_musteri_Click(object sender, EventArgs e)
        {
            new CustomerForm().ShowDialog();
        }

        private void btn_bilgisayar_Click(object sender, EventArgs e)
        {
            new ComputerForm().ShowDialog();
        }

        private void btn_oyun_Click(object sender, EventArgs e)
        {
            new GameForm().ShowDialog();
        }

        private void btn_oturum_Click(object sender, EventArgs e)
        {
            new SessionForm().ShowDialog();
        }
    }
}
