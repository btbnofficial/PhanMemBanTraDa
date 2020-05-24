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
    public partial class frmEditFood : Form
    {
        int ID;
        public frmEditFood(int foodId)
        {
            InitializeComponent();
            LoadFoodInfo(foodId);
        }

        private void LoadFoodInfo(int foodId)
        {
            Food objFood = FoodBusiness.GetFoodFromId(foodId);
            txtFoodName.Text = objFood.Name.ToString();
            ID = foodId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            double foodPrice = Double.Parse(txtFoodPrice.Text);

            bool ketQua = FoodBusiness.EditFoodPrice(ID,foodPrice);

            if(ketQua)
            {
                this.Close();
            }
        }
    }
}
