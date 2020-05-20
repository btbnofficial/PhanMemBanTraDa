namespace AppQuanTraDa
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.tpTable = new System.Windows.Forms.TabPage();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgBill = new System.Windows.Forms.DataGridView();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtgFood = new System.Windows.Forms.DataGridView();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnShowFood = new System.Windows.Forms.Button();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.txtSearchFoodName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFoodId = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nmFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTableId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dtgTableFood = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.btnEditTable = new System.Windows.Forms.Button();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cboAccountType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dtgAccount = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAcount = new System.Windows.Forms.Button();
            this.txtResetPassword = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpBill.SuspendLayout();
            this.tpFood.SuspendLayout();
            this.tpTable.SuspendLayout();
            this.tpAccount.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBill)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTableFood)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAccount)).BeginInit();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpBill);
            this.tabControl1.Controls.Add(this.tpFood);
            this.tabControl1.Controls.Add(this.tpTable);
            this.tabControl1.Controls.Add(this.tpAccount);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1032, 543);
            this.tabControl1.TabIndex = 0;
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.panel2);
            this.tpBill.Controls.Add(this.panel1);
            this.tpBill.Location = new System.Drawing.Point(4, 22);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(1024, 517);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Doanh thu";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // tpFood
            // 
            this.tpFood.Controls.Add(this.panel6);
            this.tpFood.Controls.Add(this.panel5);
            this.tpFood.Controls.Add(this.panel4);
            this.tpFood.Controls.Add(this.panel3);
            this.tpFood.Location = new System.Drawing.Point(4, 22);
            this.tpFood.Name = "tpFood";
            this.tpFood.Padding = new System.Windows.Forms.Padding(3);
            this.tpFood.Size = new System.Drawing.Size(1024, 517);
            this.tpFood.TabIndex = 1;
            this.tpFood.Text = "Mon an";
            this.tpFood.UseVisualStyleBackColor = true;
            // 
            // tpTable
            // 
            this.tpTable.Controls.Add(this.panel7);
            this.tpTable.Controls.Add(this.panel8);
            this.tpTable.Controls.Add(this.panel9);
            this.tpTable.Location = new System.Drawing.Point(4, 22);
            this.tpTable.Name = "tpTable";
            this.tpTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable.Size = new System.Drawing.Size(1024, 517);
            this.tpTable.TabIndex = 2;
            this.tpTable.Text = "Ban an";
            this.tpTable.UseVisualStyleBackColor = true;
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.panel10);
            this.tpAccount.Controls.Add(this.panel11);
            this.tpAccount.Controls.Add(this.panel12);
            this.tpAccount.Location = new System.Drawing.Point(4, 22);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(1024, 517);
            this.tpAccount.TabIndex = 3;
            this.tpAccount.Text = "Tai khoan";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnViewBill);
            this.panel1.Controls.Add(this.dtpToDate);
            this.panel1.Controls.Add(this.dtpFromDate);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 64);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgBill);
            this.panel2.Location = new System.Drawing.Point(7, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 434);
            this.panel2.TabIndex = 1;
            // 
            // dtgBill
            // 
            this.dtgBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBill.Location = new System.Drawing.Point(4, 4);
            this.dtgBill.Name = "dtgBill";
            this.dtgBill.Size = new System.Drawing.Size(1004, 427);
            this.dtgBill.TabIndex = 0;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(128, 23);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(200, 20);
            this.dtpFromDate.TabIndex = 0;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(671, 23);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(200, 20);
            this.dtpToDate.TabIndex = 1;
            // 
            // btnViewBill
            // 
            this.btnViewBill.Location = new System.Drawing.Point(465, 20);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(75, 23);
            this.btnViewBill.TabIndex = 2;
            this.btnViewBill.Text = "Thong ke";
            this.btnViewBill.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnShowFood);
            this.panel3.Controls.Add(this.btnEditFood);
            this.panel3.Controls.Add(this.btnDeleteFood);
            this.panel3.Controls.Add(this.btnAddFood);
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(586, 80);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgFood);
            this.panel4.Location = new System.Drawing.Point(6, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(586, 419);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtSearchFoodName);
            this.panel5.Controls.Add(this.btnSearchFood);
            this.panel5.Location = new System.Drawing.Point(598, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(420, 80);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.nmFoodPrice);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txtFoodName);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.txtFoodId);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(598, 92);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(420, 419);
            this.panel6.TabIndex = 2;
            // 
            // dtgFood
            // 
            this.dtgFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFood.Location = new System.Drawing.Point(4, 4);
            this.dtgFood.Name = "dtgFood";
            this.dtgFood.Size = new System.Drawing.Size(579, 412);
            this.dtgFood.TabIndex = 0;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(40, 28);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 23);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Them";
            this.btnAddFood.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(182, 28);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFood.TabIndex = 1;
            this.btnDeleteFood.Text = "Xoa";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            // 
            // btnEditFood
            // 
            this.btnEditFood.Location = new System.Drawing.Point(323, 28);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(75, 23);
            this.btnEditFood.TabIndex = 2;
            this.btnEditFood.Text = "Sua";
            this.btnEditFood.UseVisualStyleBackColor = true;
            // 
            // btnShowFood
            // 
            this.btnShowFood.Location = new System.Drawing.Point(471, 28);
            this.btnShowFood.Name = "btnShowFood";
            this.btnShowFood.Size = new System.Drawing.Size(75, 23);
            this.btnShowFood.TabIndex = 3;
            this.btnShowFood.Text = "Xem";
            this.btnShowFood.UseVisualStyleBackColor = true;
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.Location = new System.Drawing.Point(295, 28);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(75, 23);
            this.btnSearchFood.TabIndex = 4;
            this.btnSearchFood.Text = "Tim";
            this.btnSearchFood.UseVisualStyleBackColor = true;
            // 
            // txtSearchFoodName
            // 
            this.txtSearchFoodName.Location = new System.Drawing.Point(54, 30);
            this.txtSearchFoodName.Name = "txtSearchFoodName";
            this.txtSearchFoodName.Size = new System.Drawing.Size(201, 20);
            this.txtSearchFoodName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // txtFoodId
            // 
            this.txtFoodId.Location = new System.Drawing.Point(135, 35);
            this.txtFoodId.Name = "txtFoodId";
            this.txtFoodId.ReadOnly = true;
            this.txtFoodId.Size = new System.Drawing.Size(201, 20);
            this.txtFoodId.TabIndex = 6;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(135, 89);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(201, 20);
            this.txtFoodName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ten mon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gia:";
            // 
            // nmFoodPrice
            // 
            this.nmFoodPrice.Location = new System.Drawing.Point(135, 145);
            this.nmFoodPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmFoodPrice.Name = "nmFoodPrice";
            this.nmFoodPrice.Size = new System.Drawing.Size(201, 20);
            this.nmFoodPrice.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtResetPassword);
            this.panel7.Controls.Add(this.cboStatus);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.txtTableName);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.txtTableId);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(598, 92);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(420, 419);
            this.panel7.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Trang thai:";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(135, 89);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(201, 20);
            this.txtTableName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ten ban:";
            // 
            // txtTableId
            // 
            this.txtTableId.Location = new System.Drawing.Point(135, 35);
            this.txtTableId.Name = "txtTableId";
            this.txtTableId.ReadOnly = true;
            this.txtTableId.Size = new System.Drawing.Size(201, 20);
            this.txtTableId.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Id:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dtgTableFood);
            this.panel8.Location = new System.Drawing.Point(6, 92);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(586, 419);
            this.panel8.TabIndex = 4;
            // 
            // dtgTableFood
            // 
            this.dtgTableFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTableFood.Location = new System.Drawing.Point(4, 4);
            this.dtgTableFood.Name = "dtgTableFood";
            this.dtgTableFood.Size = new System.Drawing.Size(579, 412);
            this.dtgTableFood.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnShowTable);
            this.panel9.Controls.Add(this.btnEditTable);
            this.panel9.Controls.Add(this.btnDeleteTable);
            this.panel9.Controls.Add(this.btnAddTable);
            this.panel9.Location = new System.Drawing.Point(6, 6);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(586, 80);
            this.panel9.TabIndex = 3;
            // 
            // btnShowTable
            // 
            this.btnShowTable.Location = new System.Drawing.Point(471, 28);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(75, 23);
            this.btnShowTable.TabIndex = 3;
            this.btnShowTable.Text = "Xem";
            this.btnShowTable.UseVisualStyleBackColor = true;
            // 
            // btnEditTable
            // 
            this.btnEditTable.Location = new System.Drawing.Point(323, 28);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(75, 23);
            this.btnEditTable.TabIndex = 2;
            this.btnEditTable.Text = "Sua";
            this.btnEditTable.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Location = new System.Drawing.Point(182, 28);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTable.TabIndex = 1;
            this.btnDeleteTable.Text = "Xoa";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(40, 28);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(75, 23);
            this.btnAddTable.TabIndex = 0;
            this.btnAddTable.Text = "Them";
            this.btnAddTable.UseVisualStyleBackColor = true;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(135, 141);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(201, 21);
            this.cboStatus.TabIndex = 10;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.cboAccountType);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Controls.Add(this.txtAccountName);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Location = new System.Drawing.Point(598, 92);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(420, 419);
            this.panel10.TabIndex = 8;
            // 
            // cboAccountType
            // 
            this.cboAccountType.FormattingEnabled = true;
            this.cboAccountType.Location = new System.Drawing.Point(135, 77);
            this.cboAccountType.Name = "cboAccountType";
            this.cboAccountType.Size = new System.Drawing.Size(201, 21);
            this.cboAccountType.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Loai tai khoan:";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(135, 35);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.ReadOnly = true;
            this.txtAccountName.Size = new System.Drawing.Size(201, 20);
            this.txtAccountName.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ten tai khoan:";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.dtgAccount);
            this.panel11.Location = new System.Drawing.Point(6, 92);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(586, 419);
            this.panel11.TabIndex = 7;
            // 
            // dtgAccount
            // 
            this.dtgAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAccount.Location = new System.Drawing.Point(4, 4);
            this.dtgAccount.Name = "dtgAccount";
            this.dtgAccount.Size = new System.Drawing.Size(579, 412);
            this.dtgAccount.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnShowAccount);
            this.panel12.Controls.Add(this.btnEditAccount);
            this.panel12.Controls.Add(this.btnDeleteAccount);
            this.panel12.Controls.Add(this.btnAddAcount);
            this.panel12.Location = new System.Drawing.Point(6, 6);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(586, 80);
            this.panel12.TabIndex = 6;
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.Location = new System.Drawing.Point(471, 28);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(75, 23);
            this.btnShowAccount.TabIndex = 3;
            this.btnShowAccount.Text = "Xem";
            this.btnShowAccount.UseVisualStyleBackColor = true;
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(323, 28);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(75, 23);
            this.btnEditAccount.TabIndex = 2;
            this.btnEditAccount.Text = "Sua";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(182, 28);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAccount.TabIndex = 1;
            this.btnDeleteAccount.Text = "Xoa";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btnAddAcount
            // 
            this.btnAddAcount.Location = new System.Drawing.Point(40, 28);
            this.btnAddAcount.Name = "btnAddAcount";
            this.btnAddAcount.Size = new System.Drawing.Size(75, 23);
            this.btnAddAcount.TabIndex = 0;
            this.btnAddAcount.Text = "Them";
            this.btnAddAcount.UseVisualStyleBackColor = true;
            // 
            // txtResetPassword
            // 
            this.txtResetPassword.Location = new System.Drawing.Point(135, 204);
            this.txtResetPassword.Name = "txtResetPassword";
            this.txtResetPassword.Size = new System.Drawing.Size(154, 23);
            this.txtResetPassword.TabIndex = 4;
            this.txtResetPassword.Text = "Dat lai mat khau";
            this.txtResetPassword.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 567);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang quan ly ";
            this.tabControl1.ResumeLayout(false);
            this.tpBill.ResumeLayout(false);
            this.tpFood.ResumeLayout(false);
            this.tpTable.ResumeLayout(false);
            this.tpAccount.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBill)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTableFood)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAccount)).EndInit();
            this.panel12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TabPage tpFood;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown nmFoodPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFoodId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSearchFoodName;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgFood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnShowFood;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.TabPage tpTable;
        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button txtResetPassword;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTableId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dtgTableFood;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnShowTable;
        private System.Windows.Forms.Button btnEditTable;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox cboAccountType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridView dtgAccount;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAddAcount;
    }
}