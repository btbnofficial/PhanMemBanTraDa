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
        private Account logInAccout;

        public Account LogInAccout
        { 
            get => logInAccout; 
            set
            {
                logInAccout = value;
                //ChangeAccount(logInAccout.Type);
            }
        }

        public frmTableManager(Account acc)
        {
            this.LogInAccout = acc;
            InitializeComponent();
            LoadTableList();
            LoadFoodList();
        }

        #region Methods
        /*void ChangeAccount(int accountType)
        {
            if (accountType == 1)
            {
                adminToolStripMenuItem.Enabled = true;
            }
            else
            { 
                adminToolStripMenuItem.Enabled = false;
            }
        }*/

        private void LoadTableList()
        {
            flpTable.Controls.Clear();

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

        private void LoadFoodList()
        {
            cboFood.DataSource = FoodBusiness.GetFoodList();
            cboFood.DisplayMember = "Name";
        }

        #endregion

        #region Events
        private void btn_Click(object sender, EventArgs e)
        {
            int tableId = ((sender as Button).Tag as TableFood).Id;
            lsvBill.Tag = (sender as Button).Tag;
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
            frmAccountProfile f = new frmAccountProfile(this.LogInAccout);
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

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            TableFood tableFood = lsvBill.Tag as TableFood;

            int billId = BillBusiness.GetUncheckedBillIdFromTableId(tableFood.Id);
            int foodId = (cboFood.SelectedItem as Food).Id;

            //Neu Bill k co Bill nao o ban nay, them Bill moi
            if(billId == -1)
            {
                BillBusiness.AddBill(tableFood.Id);
                BillDetailBusiness.AddBillDetail(BillBusiness.GetMaxBillId(), foodId, (int)nmFoodCount.Value);
                TableFoodBusiness.ChangeTableStatus(tableFood.Id);
                LoadTableList();
            }
            //Neu bill da ton tai thì chi thêm mới BillDetail
            else
            {
                BillDetailBusiness.AddBillDetail(billId, foodId, (int)nmFoodCount.Value);
            }
            ShowBill(tableFood.Id);
        }
        //nut thanh toan
        private void button4_Click(object sender, EventArgs e)
        {
            //Xác định Bill hiện tại dựa vào table hiện tại
            //Nếu không có Bill thì k thanh toán
            //Nếu có Bill thì hỏi là có thực sự muốn thanh toán
            TableFood tableFood = lsvBill.Tag as TableFood;

            int billId = BillBusiness.GetUncheckedBillIdFromTableId(tableFood.Id);

            if(billId != -1)//Neu co Bill
            {
                double totalPrice = Double.Parse(txtTotalPrice.Text) - Double.Parse(txtTotalPrice.Text) * (int)nmDiscount.Value / 100;
                if (MessageBox.Show("Ban thuc su muon thanh toan cho " + tableFood.Name+" \n Tổng giá: "+totalPrice, "Thong bao", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    BillBusiness.CheckOut(billId);
                    TableFoodBusiness.ChangeTableStatusToEmpty(tableFood.Id);
                    ShowBill(tableFood.Id);
                    LoadTableList();
                }
            }
        }
        #endregion

        
    }
}
