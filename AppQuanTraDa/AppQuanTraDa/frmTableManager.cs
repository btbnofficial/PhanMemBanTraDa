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
using static System.Windows.Forms.ListViewItem;

namespace AppQuanTraDa
{
    public partial class frmTableManager : Form
    {
        public frmTableManager()
        {
            InitializeComponent();
            LoadTableList();
        }

        #region Methods
        private void LoadTableList()
        {
            List<TableFood> lstTableFood = TableFoodBusiness.GetListTableFood();

            foreach(TableFood tableFood in lstTableFood)
            {
                Button btn = new Button() { Width = 125, Height = 125 };
                btn.Text = tableFood.Name + "\n" + tableFood.Status;
                btn.Tag = tableFood; //Lưu object tableFood thành btn 
                if(tableFood.Status !="Trống")
                {
                    btn.BackColor = Color.Cyan;
                }
                else
                {
                    btn.BackColor = Color.WhiteSmoke;
                }
                btn.Click += btn_Click;
                flpTable.Controls.Add(btn);
            }
        }

        private void ShowBill(int tableId)
        {
            lsvBill.Items.Clear();
            List<Model.Menu> lstMenu = MenuBusiness.GetListMenuFromTableId(tableId);

            double totalPrice = 0;

            foreach(Model.Menu menu in lstMenu)
            {
                ListViewItem listViewItem = new ListViewItem(menu.FoodName.ToString());
                listViewItem.SubItems.Add(menu.Count.ToString());
                listViewItem.SubItems.Add(menu.Price.ToString());
                listViewItem.SubItems.Add(menu.TotalPrice.ToString());
                lsvBill.Items.Add(listViewItem);
                totalPrice += menu.TotalPrice;
            }
            txtTotalPrice.Text = totalPrice.ToString();
        }

        #endregion

        #region Events
        private void btn_Click(object sender, EventArgs e)
        {
            int tableId = ((sender as Button).Tag as TableFood).Id;
            ShowBill(tableId);
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
        #endregion
    }
}
