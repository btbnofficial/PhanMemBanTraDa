using AppQuanTraDa.Model;
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
    public partial class frmAccountProfile : Form
    {
        private Account logInAccout;

        public Account LogInAccout
        {
            get => logInAccout;
            set
            {
                logInAccout = value;
                ChangeAccount(logInAccout);
            }
        }
        public frmAccountProfile(Account acc)
        {
            LogInAccout = acc;
            InitializeComponent();
        }

        private void ChangeAccount(Account acc)
        {
            txtAccount.Text = LogInAccout.Username;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
