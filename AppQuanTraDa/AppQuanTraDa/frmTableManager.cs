using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanTraDa
{
    public partial class frmTableManager : Form
    {
        public frmTableManager()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thongTinCaNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountProfile f = new frmAccountProfile();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin f = new frmAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
