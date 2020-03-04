namespace ApplicationLayer
{
    partial class CreateMenue
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
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.foodidtxt = new System.Windows.Forms.TextBox();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.lab2 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.foodnametxt = new System.Windows.Forms.TextBox();
            this.lab1 = new System.Windows.Forms.Label();
            this.foodtable = new System.Windows.Forms.DataGridView();
            this.btn4 = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.TextBox();
            this.lab4 = new System.Windows.Forms.Label();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.viewbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodtable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.updatebtn);
            this.panel1.Controls.Add(this.deletebtn);
            this.panel1.Controls.Add(this.addbtn);
            this.panel1.Controls.Add(this.foodidtxt);
            this.panel1.Controls.Add(this.pricetxt);
            this.panel1.Controls.Add(this.lab2);
            this.panel1.Controls.Add(this.lab3);
            this.panel1.Controls.Add(this.foodnametxt);
            this.panel1.Controls.Add(this.lab1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 741);
            this.panel1.TabIndex = 0;
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.White;
            this.updatebtn.Location = new System.Drawing.Point(223, 347);
            this.updatebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 23);
            this.updatebtn.TabIndex = 5;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.White;
            this.deletebtn.Location = new System.Drawing.Point(124, 347);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 4;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.White;
            this.addbtn.Location = new System.Drawing.Point(28, 347);
            this.addbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 1;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // foodidtxt
            // 
            this.foodidtxt.Location = new System.Drawing.Point(115, 103);
            this.foodidtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.foodidtxt.Name = "foodidtxt";
            this.foodidtxt.Size = new System.Drawing.Size(183, 22);
            this.foodidtxt.TabIndex = 2;
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(115, 238);
            this.pricetxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(183, 22);
            this.pricetxt.TabIndex = 3;
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(25, 106);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(59, 17);
            this.lab2.TabIndex = 2;
            this.lab2.Text = "Food Id:";
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Location = new System.Drawing.Point(25, 242);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(44, 17);
            this.lab3.TabIndex = 3;
            this.lab3.Text = "Price:";
            // 
            // foodnametxt
            // 
            this.foodnametxt.Location = new System.Drawing.Point(116, 178);
            this.foodnametxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.foodnametxt.Name = "foodnametxt";
            this.foodnametxt.Size = new System.Drawing.Size(183, 22);
            this.foodnametxt.TabIndex = 1;
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(25, 178);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(85, 17);
            this.lab1.TabIndex = 1;
            this.lab1.Text = "Food Name:";
            // 
            // foodtable
            // 
            this.foodtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.foodtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodtable.Location = new System.Drawing.Point(427, 98);
            this.foodtable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.foodtable.Name = "foodtable";
            this.foodtable.RowTemplate.Height = 24;
            this.foodtable.Size = new System.Drawing.Size(703, 404);
            this.foodtable.TabIndex = 1;
            this.foodtable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.foodtable_CellContentClick);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn4.Location = new System.Drawing.Point(1131, 12);
            this.btn4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "Back";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(480, 70);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(649, 22);
            this.searchbtn.TabIndex = 7;
            this.searchbtn.TextChanged += new System.EventHandler(this.searchbtn_TextChanged);
            // 
            // lab4
            // 
            this.lab4.AutoSize = true;
            this.lab4.Location = new System.Drawing.Point(417, 73);
            this.lab4.Name = "lab4";
            this.lab4.Size = new System.Drawing.Size(57, 17);
            this.lab4.TabIndex = 8;
            this.lab4.Text = "Search:";
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logoutbtn.Location = new System.Drawing.Point(653, 681);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(219, 30);
            this.logoutbtn.TabIndex = 9;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.Color.White;
            this.refreshbtn.Location = new System.Drawing.Point(427, 530);
            this.refreshbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(75, 23);
            this.refreshbtn.TabIndex = 11;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // viewbtn
            // 
            this.viewbtn.BackColor = System.Drawing.Color.White;
            this.viewbtn.Location = new System.Drawing.Point(1053, 530);
            this.viewbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(75, 23);
            this.viewbtn.TabIndex = 12;
            this.viewbtn.Text = "View";
            this.viewbtn.UseVisualStyleBackColor = false;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // CreateMenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1239, 743);
            this.Controls.Add(this.viewbtn);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.lab4);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.foodtable);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateMenue";
            this.Text = "Create Menue";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onformclose);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodtable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox foodidtxt;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.TextBox foodnametxt;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.DataGridView foodtable;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.TextBox searchbtn;
        private System.Windows.Forms.Label lab4;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Button viewbtn;
    }
}