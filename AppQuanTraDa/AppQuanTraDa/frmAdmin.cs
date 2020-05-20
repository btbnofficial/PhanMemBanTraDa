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
            SqlParameter[] pars = new SqlParameter[1];

            pars[0] = new SqlParameter("@username", SqlDbType.VarChar, 100);
            pars[0].Value = "btbncsgo";

            string query = "execute usp_getAccountByUsername";

            dtgAccount.DataSource = DataProvider.GetList(query,pars);
        }
    }
}
