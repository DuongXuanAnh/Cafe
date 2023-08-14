namespace CafeManagement
{
    partial class fTableManager
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            accountInfoToolStripMenuItem = new ToolStripMenuItem();
            myAccountToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            nmFoodCount = new NumericUpDown();
            btnAddFood = new Button();
            cbFood = new ComboBox();
            cbCategory = new ComboBox();
            panel3 = new Panel();
            btnCheckOut = new Button();
            cbDiscount = new ComboBox();
            btnDiscount = new Button();
            cbSwtichTable = new ComboBox();
            btnSwitchTable = new Button();
            panel4 = new Panel();
            lsvBill = new ListView();
            flpTable = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, accountInfoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(891, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // accountInfoToolStripMenuItem
            // 
            accountInfoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { myAccountToolStripMenuItem, logoutToolStripMenuItem });
            accountInfoToolStripMenuItem.Name = "accountInfoToolStripMenuItem";
            accountInfoToolStripMenuItem.Size = new Size(107, 24);
            accountInfoToolStripMenuItem.Text = "Account Info";
            // 
            // myAccountToolStripMenuItem
            // 
            myAccountToolStripMenuItem.Name = "myAccountToolStripMenuItem";
            myAccountToolStripMenuItem.Size = new Size(224, 26);
            myAccountToolStripMenuItem.Text = "My account";
            myAccountToolStripMenuItem.Click += myAccountToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(224, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(nmFoodCount);
            panel2.Controls.Add(btnAddFood);
            panel2.Controls.Add(cbFood);
            panel2.Controls.Add(cbCategory);
            panel2.Location = new Point(518, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(366, 67);
            panel2.TabIndex = 2;
            // 
            // nmFoodCount
            // 
            nmFoodCount.Location = new Point(264, 23);
            nmFoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmFoodCount.Name = "nmFoodCount";
            nmFoodCount.Size = new Size(98, 27);
            nmFoodCount.TabIndex = 3;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(165, 6);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(93, 58);
            btnAddFood.TabIndex = 2;
            btnAddFood.Text = "Add Food";
            btnAddFood.UseVisualStyleBackColor = true;
            // 
            // cbFood
            // 
            cbFood.FormattingEnabled = true;
            cbFood.Location = new Point(5, 39);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(151, 28);
            cbFood.TabIndex = 1;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(5, 6);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(151, 28);
            cbCategory.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCheckOut);
            panel3.Controls.Add(cbDiscount);
            panel3.Controls.Add(btnDiscount);
            panel3.Controls.Add(cbSwtichTable);
            panel3.Controls.Add(btnSwitchTable);
            panel3.Location = new Point(518, 425);
            panel3.Name = "panel3";
            panel3.Size = new Size(366, 71);
            panel3.TabIndex = 3;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(253, 2);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(108, 62);
            btnCheckOut.TabIndex = 4;
            btnCheckOut.Text = "Checkout";
            btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // cbDiscount
            // 
            cbDiscount.FormattingEnabled = true;
            cbDiscount.Location = new Point(135, 36);
            cbDiscount.Name = "cbDiscount";
            cbDiscount.Size = new Size(108, 28);
            cbDiscount.TabIndex = 3;
            // 
            // btnDiscount
            // 
            btnDiscount.Location = new Point(133, 0);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(110, 29);
            btnDiscount.TabIndex = 2;
            btnDiscount.Text = "discount";
            btnDiscount.UseVisualStyleBackColor = true;
            // 
            // cbSwtichTable
            // 
            cbSwtichTable.FormattingEnabled = true;
            cbSwtichTable.Location = new Point(7, 36);
            cbSwtichTable.Name = "cbSwtichTable";
            cbSwtichTable.Size = new Size(108, 28);
            cbSwtichTable.TabIndex = 1;
            // 
            // btnSwitchTable
            // 
            btnSwitchTable.Location = new Point(5, 0);
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.Size = new Size(110, 29);
            btnSwitchTable.TabIndex = 0;
            btnSwitchTable.Text = "switch table";
            btnSwitchTable.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(lsvBill);
            panel4.Location = new Point(518, 104);
            panel4.Name = "panel4";
            panel4.Size = new Size(366, 318);
            panel4.TabIndex = 4;
            // 
            // lsvBill
            // 
            lsvBill.Location = new Point(3, 2);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(360, 313);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            // 
            // flpTable
            // 
            flpTable.Location = new Point(5, 31);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(507, 465);
            flpTable.TabIndex = 5;
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 509);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fTableManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Table Manager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem accountInfoToolStripMenuItem;
        private ToolStripMenuItem myAccountToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private ListView lsvBill;
        private FlowLayoutPanel flpTable;
        private NumericUpDown nmFoodCount;
        private Button btnAddFood;
        private ComboBox cbFood;
        private ComboBox cbCategory;
        private Button btnSwitchTable;
        private Button btnCheckOut;
        private ComboBox cbDiscount;
        private Button btnDiscount;
        private ComboBox cbSwtichTable;
    }
}