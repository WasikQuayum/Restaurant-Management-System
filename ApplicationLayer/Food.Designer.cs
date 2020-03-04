namespace ApplicationLayer
{
    partial class Food
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
            this.foodtable = new System.Windows.Forms.DataGridView();
            this.lab1 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.TextBox();
            this.backb = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.viewbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foodtable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 602);
            this.panel1.TabIndex = 0;
            // 
            // foodtable
            // 
            this.foodtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodtable.Location = new System.Drawing.Point(304, 67);
            this.foodtable.Margin = new System.Windows.Forms.Padding(2);
            this.foodtable.Name = "foodtable";
            this.foodtable.RowTemplate.Height = 24;
            this.foodtable.Size = new System.Drawing.Size(560, 334);
            this.foodtable.TabIndex = 1;
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(306, 43);
            this.lab1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(44, 13);
            this.lab1.TabIndex = 2;
            this.lab1.Text = "Search:";
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(353, 43);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(512, 20);
            this.searchbtn.TabIndex = 3;
            this.searchbtn.TextChanged += new System.EventHandler(this.searchbtn_TextChanged);
            // 
            // backb
            // 
            this.backb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.backb.Location = new System.Drawing.Point(854, 10);
            this.backb.Margin = new System.Windows.Forms.Padding(2);
            this.backb.Name = "backb";
            this.backb.Size = new System.Drawing.Size(56, 19);
            this.backb.TabIndex = 4;
            this.backb.Text = "Back";
            this.backb.UseVisualStyleBackColor = false;
            this.backb.Click += new System.EventHandler(this.back_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logoutbtn.Location = new System.Drawing.Point(520, 573);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(2);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(137, 22);
            this.logoutbtn.TabIndex = 5;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // viewbtn
            // 
            this.viewbtn.BackColor = System.Drawing.Color.White;
            this.viewbtn.Location = new System.Drawing.Point(436, 415);
            this.viewbtn.Margin = new System.Windows.Forms.Padding(2);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(339, 19);
            this.viewbtn.TabIndex = 6;
            this.viewbtn.Text = "View";
            this.viewbtn.UseVisualStyleBackColor = false;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(929, 604);
            this.Controls.Add(this.viewbtn);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.backb);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.foodtable);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Food";
            this.Text = "Food";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onformclose);
            ((System.ComponentModel.ISupportInitialize)(this.foodtable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView foodtable;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.TextBox searchbtn;
        private System.Windows.Forms.Button backb;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Button viewbtn;
    }
}