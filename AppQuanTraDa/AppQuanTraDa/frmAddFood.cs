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
    public partial class frmAddFood : Form
    {
        public frmAddFood()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string foodName = txtFoodName.Text;
            double foodPrice = Double.Parse(txtFoodPrice.Text);

            bool ketQua = false;
            if(String.IsNullOrEmpty(txtFoodName.Text) && String.IsNullOrEmpty(txtFoodPrice.Text))
            {
                MessageBox.Show("Bạn chưa điền đủ hoặc điều sai thông tin cần nhập!", "Thông báo");
            }
            else
            {
                ketQua = FoodBusiness.AddFood(foodName, foodPrice);
            }
            if(ketQua)
            {
                MessageBox.Show("Thêm thông tin món ăn thành công!", "Thông báo");
                this.Close();
            }
        }
    }
}
