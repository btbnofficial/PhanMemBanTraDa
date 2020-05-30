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
            }
        }
        public frmAccountProfile(Account acc)
        {
            this.LogInAccout = acc;
            InitializeComponent();
            ShowInfo(this.LogInAccout);
        }

        private void ShowInfo(Account acc)
        {
            txtAccount.Text = LogInAccout.Username;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string username = txtAccount.Text;
            string password = txtPassword.Text;
            string newPassword = txtNewPassword.Text;
            string reEnterNewPassword = txtReEnterNewPassword.Text;

            if(newPassword!=reEnterNewPassword && !String.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Mat khau moi va mat khau moi nhap lai khong giong nhau", "Alert");
            }
            else
            {
                if(this.LogInAccout.Password!=password)
                {
                    MessageBox.Show("Sai mat khau!", "Thong bao");
                }
                else
                {
                    AccountBusiness.ChangeAccountPassword(username, newPassword);
                    MessageBox.Show("Doi mat khau thanh cong!", "Thong bao");
                    this.Close();
                }
            }

        }
    }
}
