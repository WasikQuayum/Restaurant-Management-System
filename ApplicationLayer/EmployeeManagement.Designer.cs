namespace ApplicationLayer
{
    partial class EmployeeManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalaryTF = new System.Windows.Forms.TextBox();
            this.salarylab = new System.Windows.Forms.Label();
            this.PhnNumberTF1 = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DesignationTF = new System.Windows.Forms.TextBox();
            this.PhnNumberTF2 = new System.Windows.Forms.TextBox();
            this.passwordTF = new System.Windows.Forms.TextBox();
            this.EmpIdTF = new System.Windows.Forms.TextBox();
            this.EmpNameTF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lab4 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.EmpTable = new System.Windows.Forms.DataGridView();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.lab6 = new System.Windows.Forms.Label();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.ViewAllBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.SalaryTF);
            this.panel1.Controls.Add(this.salarylab);
            this.panel1.Controls.Add(this.PhnNumberTF1);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.UpdateBtn);
            this.panel1.Controls.Add(this.DesignationTF);
            this.panel1.Controls.Add(this.PhnNumberTF2);
            this.panel1.Controls.Add(this.passwordTF);
            this.panel1.Controls.Add(this.EmpIdTF);
            this.panel1.Controls.Add(this.EmpNameTF);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lab4);
            this.panel1.Controls.Add(this.lab3);
            this.panel1.Controls.Add(this.lab2);
            this.panel1.Controls.Add(this.lab1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 741);
            this.panel1.TabIndex = 0;
            // 
            // SalaryTF
            // 
            this.SalaryTF.Location = new System.Drawing.Point(133, 438);
            this.SalaryTF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SalaryTF.Name = "SalaryTF";
            this.SalaryTF.Size = new System.Drawing.Size(165, 22);
            this.SalaryTF.TabIndex = 14;
            // 
            // salarylab
            // 
            this.salarylab.AutoSize = true;
            this.salarylab.Location = new System.Drawing.Point(21, 443);
            this.salarylab.Name = "salarylab";
            this.salarylab.Size = new System.Drawing.Size(56, 17);
            this.salarylab.TabIndex = 13;
            this.salarylab.Text = "Salary: ";
            // 
            // PhnNumberTF1
            // 
            this.PhnNumberTF1.Location = new System.Drawing.Point(124, 322);
            this.PhnNumberTF1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhnNumberTF1.Name = "PhnNumberTF1";
            this.PhnNumberTF1.ReadOnly = true;
            this.PhnNumberTF1.Size = new System.Drawing.Size(45, 22);
            this.PhnNumberTF1.TabIndex = 12;
            this.PhnNumberTF1.Text = "+880";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(113, 487);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(85, 30);
            this.DeleteBtn.TabIndex = 10;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.btn2_Click_1);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(11, 487);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(85, 30);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(213, 487);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(85, 30);
            this.UpdateBtn.TabIndex = 11;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.btn3_Click);
            // 
            // DesignationTF
            // 
            this.DesignationTF.Location = new System.Drawing.Point(133, 394);
            this.DesignationTF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DesignationTF.Name = "DesignationTF";
            this.DesignationTF.Size = new System.Drawing.Size(165, 22);
            this.DesignationTF.TabIndex = 9;
            // 
            // PhnNumberTF2
            // 
            this.PhnNumberTF2.Location = new System.Drawing.Point(175, 322);
            this.PhnNumberTF2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhnNumberTF2.Name = "PhnNumberTF2";
            this.PhnNumberTF2.Size = new System.Drawing.Size(124, 22);
            this.PhnNumberTF2.TabIndex = 8;
            // 
            // passwordTF
            // 
            this.passwordTF.Location = new System.Drawing.Point(133, 246);
            this.passwordTF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTF.Name = "passwordTF";
            this.passwordTF.Size = new System.Drawing.Size(165, 22);
            this.passwordTF.TabIndex = 7;
            // 
            // EmpIdTF
            // 
            this.EmpIdTF.Location = new System.Drawing.Point(133, 177);
            this.EmpIdTF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmpIdTF.Name = "EmpIdTF";
            this.EmpIdTF.Size = new System.Drawing.Size(165, 22);
            this.EmpIdTF.TabIndex = 6;
            // 
            // EmpNameTF
            // 
            this.EmpNameTF.Location = new System.Drawing.Point(133, 108);
            this.EmpNameTF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmpNameTF.Name = "EmpNameTF";
            this.EmpNameTF.Size = new System.Drawing.Size(165, 22);
            this.EmpNameTF.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Designation:";
            // 
            // lab4
            // 
            this.lab4.AutoSize = true;
            this.lab4.Location = new System.Drawing.Point(11, 322);
            this.lab4.Name = "lab4";
            this.lab4.Size = new System.Drawing.Size(107, 17);
            this.lab4.TabIndex = 4;
            this.lab4.Text = "Phone Number:";
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Location = new System.Drawing.Point(11, 246);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(73, 17);
            this.lab3.TabIndex = 3;
            this.lab3.Text = "Password:";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(11, 182);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(89, 17);
            this.lab2.TabIndex = 2;
            this.lab2.Text = "Employee Id:";
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(11, 111);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(115, 17);
            this.lab1.TabIndex = 1;
            this.lab1.Text = "Employee Name:";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackBtn.ForeColor = System.Drawing.Color.Black;
            this.BackBtn.Location = new System.Drawing.Point(1127, 25);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(85, 30);
            this.BackBtn.TabIndex = 12;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.btn4_Click);
            // 
            // EmpTable
            // 
            this.EmpTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpTable.Location = new System.Drawing.Point(429, 114);
            this.EmpTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmpTable.Name = "EmpTable";
            this.EmpTable.RowTemplate.Height = 24;
            this.EmpTable.Size = new System.Drawing.Size(665, 489);
            this.EmpTable.TabIndex = 13;
            this.EmpTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpTableCellClicked);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(499, 86);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(596, 22);
            this.SearchBox.TabIndex = 14;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchTBValueChanged);
            // 
            // lab6
            // 
            this.lab6.AutoSize = true;
            this.lab6.Location = new System.Drawing.Point(429, 89);
            this.lab6.Name = "lab6";
            this.lab6.Size = new System.Drawing.Size(57, 17);
            this.lab6.TabIndex = 15;
            this.lab6.Text = "Search:";
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logoutbtn.Location = new System.Drawing.Point(667, 679);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(199, 30);
            this.logoutbtn.TabIndex = 16;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // ViewAllBtn
            // 
            this.ViewAllBtn.Location = new System.Drawing.Point(429, 49);
            this.ViewAllBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewAllBtn.Name = "ViewAllBtn";
            this.ViewAllBtn.Size = new System.Drawing.Size(665, 28);
            this.ViewAllBtn.TabIndex = 17;
            this.ViewAllBtn.Text = "View All Employee";
            this.ViewAllBtn.UseVisualStyleBackColor = true;
            this.ViewAllBtn.Click += new System.EventHandler(this.ViewAllBtn_Click);
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1239, 743);
            this.Controls.Add(this.ViewAllBtn);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.lab6);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.EmpTable);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeManagement";
            this.Text = "EmployeeManagement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onformclose);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox DesignationTF;
        private System.Windows.Forms.TextBox PhnNumberTF2;
        private System.Windows.Forms.TextBox passwordTF;
        private System.Windows.Forms.TextBox EmpIdTF;
        private System.Windows.Forms.TextBox EmpNameTF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lab4;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridView EmpTable;
        private System.Windows.Forms.TextBox PhnNumberTF1;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label lab6;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Button ViewAllBtn;
        private System.Windows.Forms.TextBox SalaryTF;
        private System.Windows.Forms.Label salarylab;
    }
}