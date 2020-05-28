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
            LoadTableFoodList();
            LoadFoodList();
            LoadBillList();
            LoadFoodListToComboBox();
        }

        #region Methods
        public void LoadAccountList()
        {
            dtgAccount.DataSource = AccountBusiness.LayDanhSachAccount();
        }

        public void LoadTableFoodList()
        {
            dtgTableFood.DataSource = TableFoodBusiness.GetListTableFood();
        }

        public void LoadFoodList()
        {
            dtgFood.DataSource = FoodBusiness.GetFoodList();
        }

        public void LoadBillList()
        {
            DateTime now = DateTime.Now;
            var startDate = new DateTime(now.Year, now.Month, 1);
            dtpFromDate.Value = startDate;
            dtgBill.DataSource = SavedBillBusiness.GetListSavedBill(startDate,now);
        }

        public void LoadFoodListToComboBox()
        {
            cboFoodName.DataSource = FoodBusiness.GetFoodList();
            cboFoodName.DisplayMember = "Name";

        }

        #endregion
        #region Events
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            frmAddFood f = new frmAddFood();

            f.ShowDialog();

            LoadFoodList();
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắn chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(dr==DialogResult.Yes)
            {
                int foodId;

                foodId = (int)dtgFood.CurrentRow.Cells[0].Value;

                bool ketQua = FoodBusiness.DeleteFood(foodId);

                if(ketQua)
                {
                    LoadFoodList();
                }
            }
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            int foodId;

            foodId = (int)dtgFood.CurrentRow.Cells[0].Value;

            frmFoodInfo f = new frmFoodInfo(foodId);

            f.ShowDialog();
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            int foodId;

            foodId = (int)dtgFood.CurrentRow.Cells[0].Value;

            frmEditFood f = new frmEditFood(foodId);

            f.ShowDialog();

            LoadFoodList();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAddTable_Click_1(object sender, EventArgs e)
        {
            frmAddTable f = new frmAddTable();

            f.ShowDialog();

            LoadTableFoodList();
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắn chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                int tableId;
                string status = "";

                tableId = (int)dtgTableFood.CurrentRow.Cells[0].Value;
                status = "" + dtgTableFood.CurrentRow.Cells[1].Value;

                if(status!="Trống")
                {
                    MessageBox.Show("Bạn không thể xóa bàn đang có người!", "Thông báo");
                }
                else
                {
                    bool ketQua = TableFoodBusiness.DeleteTableFood(tableId);
                    if(ketQua)
                    {
                        LoadTableFoodList();
                    }
                }
            }
        }

        private void txtTotalMoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            Food food = (Food)cboFoodName.SelectedItem;
            DateTime fromDate = dtpFromDate.Value;
            DateTime toDate = dtpToDate.Value;
            dtgBill.DataSource = SavedBillBusiness.GetListSavedBillFromFoodName(fromDate, toDate, food.Name);
            List<SavedBill> lstSavedBill = SavedBillBusiness.GetListSavedBillFromFoodName(fromDate, toDate, food.Name);
            int count = 0;
            double totalPrice = 0;
            foreach(SavedBill item in lstSavedBill)
            {
                count += item.Count;
                totalPrice += item.TotalPrice;
            }
            txtFoodCount.Text = count.ToString();
            txtTotalMoney.Text = totalPrice.ToString();
        }

        #endregion
    }
}
