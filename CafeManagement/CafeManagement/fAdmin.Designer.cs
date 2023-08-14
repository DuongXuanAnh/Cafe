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
            tpFood = new TabPage();
            tpFoodCategory = new TabPage();
            tpTable = new TabPage();
            tpAccount = new TabPage();
            tabControl1.SuspendLayout();
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
            tpBill.Location = new Point(4, 29);
            tpBill.Name = "tpBill";
            tpBill.Padding = new Padding(3);
            tpBill.Size = new Size(779, 413);
            tpBill.TabIndex = 0;
            tpBill.Text = "Bill";
            tpBill.UseVisualStyleBackColor = true;
            // 
            // tpFood
            // 
            tpFood.Location = new Point(4, 29);
            tpFood.Name = "tpFood";
            tpFood.Padding = new Padding(3);
            tpFood.Size = new Size(779, 413);
            tpFood.TabIndex = 1;
            tpFood.Text = "Food";
            tpFood.UseVisualStyleBackColor = true;
            // 
            // tpFoodCategory
            // 
            tpFoodCategory.Location = new Point(4, 29);
            tpFoodCategory.Name = "tpFoodCategory";
            tpFoodCategory.Padding = new Padding(3);
            tpFoodCategory.Size = new Size(779, 413);
            tpFoodCategory.TabIndex = 2;
            tpFoodCategory.Text = "Food Category";
            tpFoodCategory.UseVisualStyleBackColor = true;
            // 
            // tpTable
            // 
            tpTable.Location = new Point(4, 29);
            tpTable.Name = "tpTable";
            tpTable.Padding = new Padding(3);
            tpTable.Size = new Size(779, 413);
            tpTable.TabIndex = 3;
            tpTable.Text = "Table";
            tpTable.UseVisualStyleBackColor = true;
            // 
            // tpAccount
            // 
            tpAccount.Location = new Point(4, 29);
            tpAccount.Name = "tpAccount";
            tpAccount.Padding = new Padding(3);
            tpAccount.Size = new Size(911, 534);
            tpAccount.TabIndex = 4;
            tpAccount.Text = "Account";
            tpAccount.UseVisualStyleBackColor = true;
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
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpBill;
        private TabPage tpFood;
        private TabPage tpFoodCategory;
        private TabPage tpTable;
        private TabPage tpAccount;
    }
}