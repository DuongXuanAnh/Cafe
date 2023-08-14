namespace CafeManagement
{
    partial class fAdmin
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
            tabControl1 = new TabControl();
            tpBill = new TabPage();
            panel2 = new Panel();
            dgvBill = new DataGridView();
            panel1 = new Panel();
            btnViewBill = new Button();
            dtpkDateTo = new DateTimePicker();
            dtpkDateFrom = new DateTimePicker();
            tpFood = new TabPage();
            panel6 = new Panel();
            panel10 = new Panel();
            nmFoodPrice = new NumericUpDown();
            label4 = new Label();
            panel9 = new Panel();
            cbFoodCategory = new ComboBox();
            label3 = new Label();
            panel8 = new Panel();
            txbFoodName = new TextBox();
            label2 = new Label();
            panel7 = new Panel();
            txbFoodID = new TextBox();
            label1 = new Label();
            panel5 = new Panel();
            txbSearchFoodName = new TextBox();
            btnSearchFood = new Button();
            panel4 = new Panel();
            dgvFood = new DataGridView();
            panel3 = new Panel();
            btnShowFood = new Button();
            btnEditFood = new Button();
            btnDeleteFood = new Button();
            btnAddFood = new Button();
            tpFoodCategory = new TabPage();
            panel12 = new Panel();
            panel15 = new Panel();
            txbNameCategory = new TextBox();
            label7 = new Label();
            panel16 = new Panel();
            txbCategoryID = new TextBox();
            label8 = new Label();
            dgvCategory = new DataGridView();
            panel11 = new Panel();
            btnShowCategory = new Button();
            btnEditCategory = new Button();
            btnDeleteCategory = new Button();
            btnAddCategory = new Button();
            tpTable = new TabPage();
            panel13 = new Panel();
            panel19 = new Panel();
            cbTableStatus = new ComboBox();
            label9 = new Label();
            panel14 = new Panel();
            txbTableName = new TextBox();
            label5 = new Label();
            panel17 = new Panel();
            txbTableID = new TextBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            panel18 = new Panel();
            btnShowTable = new Button();
            btnEditTable = new Button();
            btnDeleteTable = new Button();
            btnAddTable = new Button();
            tpAccount = new TabPage();
            panel20 = new Panel();
            panel21 = new Panel();
            cbTypeAccount = new ComboBox();
            label10 = new Label();
            panel22 = new Panel();
            txbDisplaynameAccount = new TextBox();
            label11 = new Label();
            panel23 = new Panel();
            txbUsernameAccount = new TextBox();
            label12 = new Label();
            dataGridView2 = new DataGridView();
            panel24 = new Panel();
            btnShowAccount = new Button();
            btnEditAccount = new Button();
            btnDeleteAccount = new Button();
            btnAddAccount = new Button();
            tabControl1.SuspendLayout();
            tpBill.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBill).BeginInit();
            panel1.SuspendLayout();
            tpFood.SuspendLayout();
            panel6.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFood).BeginInit();
            panel3.SuspendLayout();
            tpFoodCategory.SuspendLayout();
            panel12.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            panel11.SuspendLayout();
            tpTable.SuspendLayout();
            panel13.SuspendLayout();
            panel19.SuspendLayout();
            panel14.SuspendLayout();
            panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel18.SuspendLayout();
            tpAccount.SuspendLayout();
            panel20.SuspendLayout();
            panel21.SuspendLayout();
            panel22.SuspendLayout();
            panel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel24.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpBill);
            tabControl1.Controls.Add(tpFood);
            tabControl1.Controls.Add(tpFoodCategory);
            tabControl1.Controls.Add(tpTable);
            tabControl1.Controls.Add(tpAccount);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(919, 567);
            tabControl1.TabIndex = 0;
            // 
            // tpBill
            // 
            tpBill.Controls.Add(panel2);
            tpBill.Controls.Add(panel1);
            tpBill.Location = new Point(4, 29);
            tpBill.Name = "tpBill";
            tpBill.Padding = new Padding(3);
            tpBill.Size = new Size(911, 534);
            tpBill.TabIndex = 0;
            tpBill.Text = "Bill";
            tpBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvBill);
            panel2.Location = new Point(3, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(904, 462);
            panel2.TabIndex = 1;
            // 
            // dgvBill
            // 
            dgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBill.Location = new Point(3, 3);
            dgvBill.Name = "dgvBill";
            dgvBill.RowHeadersWidth = 51;
            dgvBill.RowTemplate.Height = 29;
            dgvBill.Size = new Size(898, 455);
            dgvBill.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnViewBill);
            panel1.Controls.Add(dtpkDateTo);
            panel1.Controls.Add(dtpkDateFrom);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(905, 61);
            panel1.TabIndex = 0;
            // 
            // btnViewBill
            // 
            btnViewBill.Location = new Point(397, 14);
            btnViewBill.Name = "btnViewBill";
            btnViewBill.Size = new Size(138, 29);
            btnViewBill.TabIndex = 2;
            btnViewBill.Text = "View Bill";
            btnViewBill.UseVisualStyleBackColor = true;
            // 
            // dtpkDateTo
            // 
            dtpkDateTo.Location = new Point(641, 14);
            dtpkDateTo.Name = "dtpkDateTo";
            dtpkDateTo.Size = new Size(250, 27);
            dtpkDateTo.TabIndex = 1;
            // 
            // dtpkDateFrom
            // 
            dtpkDateFrom.Location = new Point(14, 14);
            dtpkDateFrom.Name = "dtpkDateFrom";
            dtpkDateFrom.Size = new Size(259, 27);
            dtpkDateFrom.TabIndex = 0;
            // 
            // tpFood
            // 
            tpFood.Controls.Add(panel6);
            tpFood.Controls.Add(panel5);
            tpFood.Controls.Add(panel4);
            tpFood.Controls.Add(panel3);
            tpFood.Location = new Point(4, 29);
            tpFood.Name = "tpFood";
            tpFood.Padding = new Padding(3);
            tpFood.Size = new Size(911, 534);
            tpFood.TabIndex = 1;
            tpFood.Text = "Food";
            tpFood.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel10);
            panel6.Controls.Add(panel9);
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(570, 97);
            panel6.Name = "panel6";
            panel6.Size = new Size(335, 430);
            panel6.TabIndex = 3;
            // 
            // panel10
            // 
            panel10.Controls.Add(nmFoodPrice);
            panel10.Controls.Add(label4);
            panel10.Location = new Point(8, 180);
            panel10.Name = "panel10";
            panel10.Size = new Size(327, 53);
            panel10.TabIndex = 4;
            // 
            // nmFoodPrice
            // 
            nmFoodPrice.Location = new Point(101, 12);
            nmFoodPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nmFoodPrice.Name = "nmFoodPrice";
            nmFoodPrice.Size = new Size(211, 27);
            nmFoodPrice.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(31, 14);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 0;
            label4.Text = "Price:";
            // 
            // panel9
            // 
            panel9.Controls.Add(cbFoodCategory);
            panel9.Controls.Add(label3);
            panel9.Location = new Point(8, 121);
            panel9.Name = "panel9";
            panel9.Size = new Size(327, 53);
            panel9.TabIndex = 3;
            // 
            // cbFoodCategory
            // 
            cbFoodCategory.FormattingEnabled = true;
            cbFoodCategory.Location = new Point(101, 14);
            cbFoodCategory.Name = "cbFoodCategory";
            cbFoodCategory.Size = new Size(211, 28);
            cbFoodCategory.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(7, 17);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 0;
            label3.Text = "Category:";
            // 
            // panel8
            // 
            panel8.Controls.Add(txbFoodName);
            panel8.Controls.Add(label2);
            panel8.Location = new Point(8, 62);
            panel8.Name = "panel8";
            panel8.Size = new Size(327, 53);
            panel8.TabIndex = 2;
            // 
            // txbFoodName
            // 
            txbFoodName.Location = new Point(101, 10);
            txbFoodName.Name = "txbFoodName";
            txbFoodName.ReadOnly = true;
            txbFoodName.Size = new Size(211, 27);
            txbFoodName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(7, 17);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 0;
            label2.Text = "Food name:";
            // 
            // panel7
            // 
            panel7.Controls.Add(txbFoodID);
            panel7.Controls.Add(label1);
            panel7.Location = new Point(5, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(327, 53);
            panel7.TabIndex = 0;
            // 
            // txbFoodID
            // 
            txbFoodID.Location = new Point(104, 14);
            txbFoodID.Name = "txbFoodID";
            txbFoodID.ReadOnly = true;
            txbFoodID.Size = new Size(211, 27);
            txbFoodID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 17);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // panel5
            // 
            panel5.Controls.Add(txbSearchFoodName);
            panel5.Controls.Add(btnSearchFood);
            panel5.Location = new Point(570, 18);
            panel5.Name = "panel5";
            panel5.Size = new Size(336, 70);
            panel5.TabIndex = 2;
            // 
            // txbSearchFoodName
            // 
            txbSearchFoodName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbSearchFoodName.Location = new Point(3, 17);
            txbSearchFoodName.Name = "txbSearchFoodName";
            txbSearchFoodName.Size = new Size(230, 34);
            txbSearchFoodName.TabIndex = 1;
            // 
            // btnSearchFood
            // 
            btnSearchFood.Location = new Point(239, 3);
            btnSearchFood.Name = "btnSearchFood";
            btnSearchFood.Size = new Size(94, 59);
            btnSearchFood.TabIndex = 0;
            btnSearchFood.Text = "Seach";
            btnSearchFood.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvFood);
            panel4.Location = new Point(8, 94);
            panel4.Name = "panel4";
            panel4.Size = new Size(551, 434);
            panel4.TabIndex = 1;
            // 
            // dgvFood
            // 
            dgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFood.Location = new Point(0, 0);
            dgvFood.Name = "dgvFood";
            dgvFood.RowHeadersWidth = 51;
            dgvFood.RowTemplate.Height = 29;
            dgvFood.Size = new Size(551, 434);
            dgvFood.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnShowFood);
            panel3.Controls.Add(btnEditFood);
            panel3.Controls.Add(btnDeleteFood);
            panel3.Controls.Add(btnAddFood);
            panel3.Location = new Point(8, 18);
            panel3.Name = "panel3";
            panel3.Size = new Size(551, 70);
            panel3.TabIndex = 0;
            // 
            // btnShowFood
            // 
            btnShowFood.Location = new Point(457, 0);
            btnShowFood.Name = "btnShowFood";
            btnShowFood.Size = new Size(94, 62);
            btnShowFood.TabIndex = 3;
            btnShowFood.Text = "Show";
            btnShowFood.UseVisualStyleBackColor = true;
            // 
            // btnEditFood
            // 
            btnEditFood.Location = new Point(303, 0);
            btnEditFood.Name = "btnEditFood";
            btnEditFood.Size = new Size(94, 62);
            btnEditFood.TabIndex = 2;
            btnEditFood.Text = "Edit";
            btnEditFood.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Location = new Point(149, 0);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(94, 62);
            btnDeleteFood.TabIndex = 1;
            btnDeleteFood.Text = "Delete";
            btnDeleteFood.UseVisualStyleBackColor = true;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(0, 0);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(94, 62);
            btnAddFood.TabIndex = 0;
            btnAddFood.Text = "Add";
            btnAddFood.UseVisualStyleBackColor = true;
            // 
            // tpFoodCategory
            // 
            tpFoodCategory.Controls.Add(panel12);
            tpFoodCategory.Controls.Add(dgvCategory);
            tpFoodCategory.Controls.Add(panel11);
            tpFoodCategory.Location = new Point(4, 29);
            tpFoodCategory.Name = "tpFoodCategory";
            tpFoodCategory.Padding = new Padding(3);
            tpFoodCategory.Size = new Size(911, 534);
            tpFoodCategory.TabIndex = 2;
            tpFoodCategory.Text = "Food Category";
            tpFoodCategory.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            panel12.Controls.Add(panel15);
            panel12.Controls.Add(panel16);
            panel12.Location = new Point(570, 98);
            panel12.Name = "panel12";
            panel12.Size = new Size(335, 430);
            panel12.TabIndex = 4;
            // 
            // panel15
            // 
            panel15.Controls.Add(txbNameCategory);
            panel15.Controls.Add(label7);
            panel15.Location = new Point(8, 62);
            panel15.Name = "panel15";
            panel15.Size = new Size(327, 53);
            panel15.TabIndex = 2;
            // 
            // txbNameCategory
            // 
            txbNameCategory.Location = new Point(101, 10);
            txbNameCategory.Name = "txbNameCategory";
            txbNameCategory.Size = new Size(211, 27);
            txbNameCategory.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(7, 17);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 0;
            label7.Text = "Category:";
            // 
            // panel16
            // 
            panel16.Controls.Add(txbCategoryID);
            panel16.Controls.Add(label8);
            panel16.Location = new Point(5, 3);
            panel16.Name = "panel16";
            panel16.Size = new Size(327, 53);
            panel16.TabIndex = 0;
            // 
            // txbCategoryID
            // 
            txbCategoryID.Location = new Point(104, 14);
            txbCategoryID.Name = "txbCategoryID";
            txbCategoryID.ReadOnly = true;
            txbCategoryID.Size = new Size(211, 27);
            txbCategoryID.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(34, 17);
            label8.Name = "label8";
            label8.Size = new Size(29, 20);
            label8.TabIndex = 0;
            label8.Text = "ID:";
            // 
            // dgvCategory
            // 
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Location = new Point(6, 94);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.RowTemplate.Height = 29;
            dgvCategory.Size = new Size(551, 434);
            dgvCategory.TabIndex = 2;
            // 
            // panel11
            // 
            panel11.Controls.Add(btnShowCategory);
            panel11.Controls.Add(btnEditCategory);
            panel11.Controls.Add(btnDeleteCategory);
            panel11.Controls.Add(btnAddCategory);
            panel11.Location = new Point(6, 6);
            panel11.Name = "panel11";
            panel11.Size = new Size(551, 70);
            panel11.TabIndex = 1;
            // 
            // btnShowCategory
            // 
            btnShowCategory.Location = new Point(457, 0);
            btnShowCategory.Name = "btnShowCategory";
            btnShowCategory.Size = new Size(94, 62);
            btnShowCategory.TabIndex = 3;
            btnShowCategory.Text = "Show";
            btnShowCategory.UseVisualStyleBackColor = true;
            // 
            // btnEditCategory
            // 
            btnEditCategory.Location = new Point(303, 0);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(94, 62);
            btnEditCategory.TabIndex = 2;
            btnEditCategory.Text = "Edit";
            btnEditCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(149, 0);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(94, 62);
            btnDeleteCategory.TabIndex = 1;
            btnDeleteCategory.Text = "Delete";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(0, 0);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(94, 62);
            btnAddCategory.TabIndex = 0;
            btnAddCategory.Text = "Add";
            btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // tpTable
            // 
            tpTable.Controls.Add(panel13);
            tpTable.Controls.Add(dataGridView1);
            tpTable.Controls.Add(panel18);
            tpTable.Location = new Point(4, 29);
            tpTable.Name = "tpTable";
            tpTable.Padding = new Padding(3);
            tpTable.Size = new Size(911, 534);
            tpTable.TabIndex = 3;
            tpTable.Text = "Table";
            tpTable.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            panel13.Controls.Add(panel19);
            panel13.Controls.Add(panel14);
            panel13.Controls.Add(panel17);
            panel13.Location = new Point(570, 98);
            panel13.Name = "panel13";
            panel13.Size = new Size(335, 430);
            panel13.TabIndex = 7;
            // 
            // panel19
            // 
            panel19.Controls.Add(cbTableStatus);
            panel19.Controls.Add(label9);
            panel19.Location = new Point(8, 121);
            panel19.Name = "panel19";
            panel19.Size = new Size(327, 53);
            panel19.TabIndex = 4;
            // 
            // cbTableStatus
            // 
            cbTableStatus.FormattingEnabled = true;
            cbTableStatus.Location = new Point(101, 14);
            cbTableStatus.Name = "cbTableStatus";
            cbTableStatus.Size = new Size(211, 28);
            cbTableStatus.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(21, 17);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 0;
            label9.Text = "Status:";
            // 
            // panel14
            // 
            panel14.Controls.Add(txbTableName);
            panel14.Controls.Add(label5);
            panel14.Location = new Point(8, 62);
            panel14.Name = "panel14";
            panel14.Size = new Size(327, 53);
            panel14.TabIndex = 2;
            // 
            // txbTableName
            // 
            txbTableName.Location = new Point(101, 10);
            txbTableName.Name = "txbTableName";
            txbTableName.Size = new Size(211, 27);
            txbTableName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(4, 13);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 0;
            label5.Text = "table name:";
            // 
            // panel17
            // 
            panel17.Controls.Add(txbTableID);
            panel17.Controls.Add(label6);
            panel17.Location = new Point(5, 3);
            panel17.Name = "panel17";
            panel17.Size = new Size(327, 53);
            panel17.TabIndex = 0;
            // 
            // txbTableID
            // 
            txbTableID.Location = new Point(104, 14);
            txbTableID.Name = "txbTableID";
            txbTableID.ReadOnly = true;
            txbTableID.Size = new Size(211, 27);
            txbTableID.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(34, 17);
            label6.Name = "label6";
            label6.Size = new Size(29, 20);
            label6.TabIndex = 0;
            label6.Text = "ID:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(551, 434);
            dataGridView1.TabIndex = 6;
            // 
            // panel18
            // 
            panel18.Controls.Add(btnShowTable);
            panel18.Controls.Add(btnEditTable);
            panel18.Controls.Add(btnDeleteTable);
            panel18.Controls.Add(btnAddTable);
            panel18.Location = new Point(6, 6);
            panel18.Name = "panel18";
            panel18.Size = new Size(551, 70);
            panel18.TabIndex = 5;
            // 
            // btnShowTable
            // 
            btnShowTable.Location = new Point(457, 0);
            btnShowTable.Name = "btnShowTable";
            btnShowTable.Size = new Size(94, 62);
            btnShowTable.TabIndex = 3;
            btnShowTable.Text = "Show";
            btnShowTable.UseVisualStyleBackColor = true;
            // 
            // btnEditTable
            // 
            btnEditTable.Location = new Point(303, 0);
            btnEditTable.Name = "btnEditTable";
            btnEditTable.Size = new Size(94, 62);
            btnEditTable.TabIndex = 2;
            btnEditTable.Text = "Edit";
            btnEditTable.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Location = new Point(149, 0);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(94, 62);
            btnDeleteTable.TabIndex = 1;
            btnDeleteTable.Text = "Delete";
            btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(0, 0);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(94, 62);
            btnAddTable.TabIndex = 0;
            btnAddTable.Text = "Add";
            btnAddTable.UseVisualStyleBackColor = true;
            // 
            // tpAccount
            // 
            tpAccount.Controls.Add(panel20);
            tpAccount.Controls.Add(dataGridView2);
            tpAccount.Controls.Add(panel24);
            tpAccount.Location = new Point(4, 29);
            tpAccount.Name = "tpAccount";
            tpAccount.Padding = new Padding(3);
            tpAccount.Size = new Size(911, 534);
            tpAccount.TabIndex = 4;
            tpAccount.Text = "Account";
            tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel20
            // 
            panel20.Controls.Add(panel21);
            panel20.Controls.Add(panel22);
            panel20.Controls.Add(panel23);
            panel20.Location = new Point(570, 98);
            panel20.Name = "panel20";
            panel20.Size = new Size(335, 430);
            panel20.TabIndex = 10;
            // 
            // panel21
            // 
            panel21.Controls.Add(cbTypeAccount);
            panel21.Controls.Add(label10);
            panel21.Location = new Point(8, 121);
            panel21.Name = "panel21";
            panel21.Size = new Size(327, 53);
            panel21.TabIndex = 4;
            // 
            // cbTypeAccount
            // 
            cbTypeAccount.FormattingEnabled = true;
            cbTypeAccount.Location = new Point(113, 14);
            cbTypeAccount.Name = "cbTypeAccount";
            cbTypeAccount.Size = new Size(211, 28);
            cbTypeAccount.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(21, 17);
            label10.Name = "label10";
            label10.Size = new Size(46, 20);
            label10.TabIndex = 0;
            label10.Text = "Type:";
            // 
            // panel22
            // 
            panel22.Controls.Add(txbDisplaynameAccount);
            panel22.Controls.Add(label11);
            panel22.Location = new Point(8, 62);
            panel22.Name = "panel22";
            panel22.Size = new Size(327, 53);
            panel22.TabIndex = 2;
            // 
            // txbDisplaynameAccount
            // 
            txbDisplaynameAccount.Location = new Point(113, 10);
            txbDisplaynameAccount.Name = "txbDisplaynameAccount";
            txbDisplaynameAccount.Size = new Size(211, 27);
            txbDisplaynameAccount.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(4, 13);
            label11.Name = "label11";
            label11.Size = new Size(107, 20);
            label11.TabIndex = 0;
            label11.Text = "Display name:";
            // 
            // panel23
            // 
            panel23.Controls.Add(txbUsernameAccount);
            panel23.Controls.Add(label12);
            panel23.Location = new Point(5, 3);
            panel23.Name = "panel23";
            panel23.Size = new Size(327, 53);
            panel23.TabIndex = 0;
            // 
            // txbUsernameAccount
            // 
            txbUsernameAccount.Location = new Point(113, 14);
            txbUsernameAccount.Name = "txbUsernameAccount";
            txbUsernameAccount.ReadOnly = true;
            txbUsernameAccount.Size = new Size(211, 27);
            txbUsernameAccount.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(7, 17);
            label12.Name = "label12";
            label12.Size = new Size(84, 20);
            label12.TabIndex = 0;
            label12.Text = "Username:";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 94);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(551, 434);
            dataGridView2.TabIndex = 9;
            // 
            // panel24
            // 
            panel24.Controls.Add(btnShowAccount);
            panel24.Controls.Add(btnEditAccount);
            panel24.Controls.Add(btnDeleteAccount);
            panel24.Controls.Add(btnAddAccount);
            panel24.Location = new Point(6, 6);
            panel24.Name = "panel24";
            panel24.Size = new Size(551, 70);
            panel24.TabIndex = 8;
            // 
            // btnShowAccount
            // 
            btnShowAccount.Location = new Point(457, 0);
            btnShowAccount.Name = "btnShowAccount";
            btnShowAccount.Size = new Size(94, 62);
            btnShowAccount.TabIndex = 3;
            btnShowAccount.Text = "Show";
            btnShowAccount.UseVisualStyleBackColor = true;
            // 
            // btnEditAccount
            // 
            btnEditAccount.Location = new Point(303, 0);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(94, 62);
            btnEditAccount.TabIndex = 2;
            btnEditAccount.Text = "Edit";
            btnEditAccount.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(149, 0);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(94, 62);
            btnDeleteAccount.TabIndex = 1;
            btnDeleteAccount.Text = "Delete";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new Point(0, 0);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(94, 62);
            btnAddAccount.TabIndex = 0;
            btnAddAccount.Text = "Add";
            btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 584);
            Controls.Add(tabControl1);
            Name = "fAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            tabControl1.ResumeLayout(false);
            tpBill.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
            panel1.ResumeLayout(false);
            tpFood.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFood).EndInit();
            panel3.ResumeLayout(false);
            tpFoodCategory.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            panel11.ResumeLayout(false);
            tpTable.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel18.ResumeLayout(false);
            tpAccount.ResumeLayout(false);
            panel20.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panel22.ResumeLayout(false);
            panel22.PerformLayout();
            panel23.ResumeLayout(false);
            panel23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel24.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpBill;
        private TabPage tpFood;
        private TabPage tpFoodCategory;
        private TabPage tpTable;
        private TabPage tpAccount;
        private Panel panel2;
        private DataGridView dgvBill;
        private Panel panel1;
        private Button btnViewBill;
        private DateTimePicker dtpkDateTo;
        private DateTimePicker dtpkDateFrom;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private DataGridView dgvFood;
        private Button btnShowFood;
        private Button btnEditFood;
        private Button btnDeleteFood;
        private Button btnAddFood;
        private Button btnSearchFood;
        private Panel panel7;
        private TextBox txbFoodID;
        private Label label1;
        private TextBox txbSearchFoodName;
        private Panel panel8;
        private TextBox txbFoodName;
        private Label label2;
        private Panel panel9;
        private ComboBox cbFoodCategory;
        private Label label3;
        private Panel panel10;
        private NumericUpDown nmFoodPrice;
        private Label label4;
        private Panel panel12;
        private Panel panel13;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private ComboBox cbTableStatus;
        private Panel panel15;
        private TextBox txbNameCategory;
        private Label label7;
        private Panel panel16;
        private TextBox txbCategoryID;
        private Label label8;
        private DataGridView dgvCategory;
        private Panel panel11;
        private Button btnShowCategory;
        private Button btnEditCategory;
        private Button btnDeleteCategory;
        private Button btnAddCategory;
        private Panel panel19;
        private Label label9;
        private Panel panel14;
        private TextBox txbTableName;
        private Panel panel17;
        private TextBox txbTableID;
        private Label label6;
        private DataGridView dataGridView1;
        private Panel panel18;
        private Button btnShowTable;
        private Button btnEditTable;
        private Button btnDeleteTable;
        private Button btnAddTable;
        private Panel panel20;
        private Panel panel21;
        private ComboBox cbTypeAccount;
        private Label label10;
        private Panel panel22;
        private TextBox txbDisplaynameAccount;
        private Label label11;
        private Panel panel23;
        private TextBox txbUsernameAccount;
        private Label label12;
        private DataGridView dataGridView2;
        private Panel panel24;
        private Button btnShowAccount;
        private Button btnEditAccount;
        private Button btnDeleteAccount;
        private Button btnAddAccount;
    }
}