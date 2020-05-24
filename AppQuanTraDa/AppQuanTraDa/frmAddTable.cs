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
    public partial class frmAddTable : Form
    {
        public frmAddTable()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string tableName = txtTableName.Text;

            bool ketQua = false;

            if(!String.IsNullOrEmpty(tableName))
            {
                ketQua = TableFoodBusiness.AddTableFood(tableName);
            }
            if(ketQua)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Them ban khong thanh cong!", "Thong bao");
            }
        }
    }
}
