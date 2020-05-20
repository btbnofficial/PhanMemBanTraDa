using AppQuanTraDa.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanTraDa
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            LoadAccountList();
        }

        public void LoadAccountList()
        {
            dtgAccount.DataSource = AccountBusiness.LayDanhSachAccount();
        }
    }
}
