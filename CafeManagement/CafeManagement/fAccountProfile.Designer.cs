namespace CafeManagement
{
    partial class fAccountProfile
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
            panel1 = new Panel();
            btnCancel = new Button();
            btnUpdate = new Button();
            panel6 = new Panel();
            txtRePassword = new TextBox();
            label5 = new Label();
            panel5 = new Panel();
            txtNewPassword = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            txtPassword = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            txtDisplayName = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            txbUserName = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(6, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(532, 386);
            panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(400, 323);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(121, 46);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(273, 323);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 46);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtRePassword);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(6, 252);
            panel6.Name = "panel6";
            panel6.Size = new Size(515, 55);
            panel6.TabIndex = 5;
            // 
            // txtRePassword
            // 
            txtRePassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRePassword.Location = new Point(163, 10);
            txtRePassword.Name = "txtRePassword";
            txtRePassword.Size = new Size(349, 34);
            txtRePassword.TabIndex = 1;
            txtRePassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(13, 10);
            label5.Name = "label5";
            label5.Size = new Size(130, 28);
            label5.TabIndex = 0;
            label5.Text = "Repassword:";
            // 
            // panel5
            // 
            panel5.Controls.Add(txtNewPassword);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(6, 191);
            panel5.Name = "panel5";
            panel5.Size = new Size(515, 55);
            panel5.TabIndex = 4;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewPassword.Location = new Point(163, 10);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(349, 34);
            txtNewPassword.TabIndex = 1;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 13);
            label4.Name = "label4";
            label4.Size = new Size(155, 28);
            label4.TabIndex = 0;
            label4.Text = "New password:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtPassword);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(6, 130);
            panel4.Name = "panel4";
            panel4.Size = new Size(515, 55);
            panel4.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(163, 10);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(349, 34);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 10);
            label3.Name = "label3";
            label3.Size = new Size(106, 28);
            label3.TabIndex = 0;
            label3.Text = "Password:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtDisplayName);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(6, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(515, 55);
            panel3.TabIndex = 2;
            // 
            // txtDisplayName
            // 
            txtDisplayName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDisplayName.Location = new Point(163, 10);
            txtDisplayName.Name = "txtDisplayName";
            txtDisplayName.Size = new Size(349, 34);
            txtDisplayName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 0;
            label2.Text = "Display name:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbUserName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(6, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(515, 55);
            panel2.TabIndex = 1;
            // 
            // txbUserName
            // 
            txbUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbUserName.Location = new Point(163, 10);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(349, 34);
            txbUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 0;
            label1.Text = "UserName:";
            // 
            // fAccountProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(553, 402);
            Controls.Add(panel1);
            Name = "fAccountProfile";
            Text = "Profile";
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCancel;
        private Button btnUpdate;
        private Panel panel6;
        private TextBox txtRePassword;
        private Label label5;
        private Panel panel5;
        private TextBox txtNewPassword;
        private Label label4;
        private Panel panel4;
        private TextBox txtPassword;
        private Label label3;
        private Panel panel3;
        private TextBox txtDisplayName;
        private Label label2;
        private Panel panel2;
        private TextBox txbUserName;
        private Label label1;
    }
}