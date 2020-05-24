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
    public partial class frmFoodInfo : Form
    {
        public frmFoodInfo(int foodId)
        {
            InitializeComponent();
            LoadFoodInfo(foodId);
        }

        private void LoadFoodInfo(int foodId)
        {
            Food objFood = FoodBusiness.GetFoodFromId(foodId);
            txtFoodName.Text = objFood.Name.ToString();
            txtFoodPrice.Text = objFood.Price.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
