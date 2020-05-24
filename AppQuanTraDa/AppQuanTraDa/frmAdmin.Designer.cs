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
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dtgAccount = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAcount = new System.Windows.Forms.Button();
            this.tpTable = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dtgTableFood = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgFood = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShowFood = new System.Windows.Forms.Button();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpAccount.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAccount)).BeginInit();
            this.panel12.SuspendLayout();
            this.tpTable.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTableFood)).BeginInit();
            this.panel9.SuspendLayout();
            this.tpFood.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFood)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpAccount
            // 
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
            // panel11
            // 
            this.panel11.Controls.Add(this.dtgAccount);
            this.panel11.Location = new System.Drawing.Point(6, 92);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1015, 419);
            this.panel11.TabIndex = 7;
            // 
            // dtgAccount
            // 
            this.dtgAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAccount.Location = new System.Drawing.Point(4, 4);
            this.dtgAccount.Name = "dtgAccount";
            this.dtgAccount.Size = new System.Drawing.Size(1008, 412);
            this.dtgAccount.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnShowAccount);
            this.panel12.Controls.Add(this.btnEditAccount);
            this.panel12.Controls.Add(this.btnDeleteAccount);
            this.panel12.Controls.Add(this.btnAddAcount);
            this.panel12.Location = new System.Drawing.Point(432, 6);
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
            // tpTable
            // 
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
            // panel8
            // 
            this.panel8.Controls.Add(this.dtgTableFood);
            this.panel8.Location = new System.Drawing.Point(6, 92);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1015, 419);
            this.panel8.TabIndex = 4;
            // 
            // dtgTableFood
            // 
            this.dtgTableFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTableFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTableFood.Location = new System.Drawing.Point(4, 4);
            this.dtgTableFood.Name = "dtgTableFood";
            this.dtgTableFood.Size = new System.Drawing.Size(1008, 412);
            this.dtgTableFood.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnShowTable);
            this.panel9.Controls.Add(this.btnAddTable);
            this.panel9.Location = new System.Drawing.Point(432, 6);
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
            this.btnShowTable.Text = "Xoa";
            this.btnShowTable.UseVisualStyleBackColor = true;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(323, 28);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(75, 23);
            this.btnAddTable.TabIndex = 2;
            this.btnAddTable.Text = "Them";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click_1);
            // 
            // tpFood
            // 
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
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgFood);
            this.panel4.Location = new System.Drawing.Point(6, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1012, 419);
            this.panel4.TabIndex = 1;
            // 
            // dtgFood
            // 
            this.dtgFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFood.Location = new System.Drawing.Point(3, 4);
            this.dtgFood.Name = "dtgFood";
            this.dtgFood.Size = new System.Drawing.Size(1006, 412);
            this.dtgFood.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnShowFood);
            this.panel3.Controls.Add(this.btnEditFood);
            this.panel3.Controls.Add(this.btnDeleteFood);
            this.panel3.Controls.Add(this.btnAddFood);
            this.panel3.Location = new System.Drawing.Point(432, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(586, 80);
            this.panel3.TabIndex = 0;
            // 
            // btnShowFood
            // 
            this.btnShowFood.Location = new System.Drawing.Point(471, 28);
            this.btnShowFood.Name = "btnShowFood";
            this.btnShowFood.Size = new System.Drawing.Size(75, 23);
            this.btnShowFood.TabIndex = 3;
            this.btnShowFood.Text = "Xem";
            this.btnShowFood.UseVisualStyleBackColor = true;
            this.btnShowFood.Click += new System.EventHandler(this.btnShowFood_Click);
            // 
            // btnEditFood
            // 
            this.btnEditFood.Location = new System.Drawing.Point(323, 28);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(75, 23);
            this.btnEditFood.TabIndex = 2;
            this.btnEditFood.Text = "Sua";
            this.btnEditFood.UseVisualStyleBackColor = true;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(182, 28);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFood.TabIndex = 1;
            this.btnDeleteFood.Text = "Xoa";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(40, 28);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 23);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Them";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpFood);
            this.tabControl1.Controls.Add(this.tpTable);
            this.tabControl1.Controls.Add(this.tpAccount);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1032, 543);
            this.tabControl1.TabIndex = 0;
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
            this.tpAccount.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAccount)).EndInit();
            this.panel12.ResumeLayout(false);
            this.tpTable.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTableFood)).EndInit();
            this.panel9.ResumeLayout(false);
            this.tpFood.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFood)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridView dtgAccount;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAddAcount;
        private System.Windows.Forms.TabPage tpTable;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dtgTableFood;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnShowTable;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.TabPage tpFood;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgFood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnShowFood;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.TabControl tabControl1;
    }
}