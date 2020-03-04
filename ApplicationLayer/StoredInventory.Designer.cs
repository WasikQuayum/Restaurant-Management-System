namespace ApplicationLayer
{
    partial class StoredInventory
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
            this.inventorytable = new System.Windows.Forms.DataGridView();
            this.lab1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.viewbtn = new System.Windows.Forms.Button();
            this.totalbtn = new System.Windows.Forms.Button();
            this.totalsum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventorytable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 741);
            this.panel1.TabIndex = 0;
            // 
            // inventorytable
            // 
            this.inventorytable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventorytable.Location = new System.Drawing.Point(417, 110);
            this.inventorytable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inventorytable.Name = "inventorytable";
            this.inventorytable.RowTemplate.Height = 24;
            this.inventorytable.Size = new System.Drawing.Size(757, 433);
            this.inventorytable.TabIndex = 1;
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(419, 84);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(57, 17);
            this.lab1.TabIndex = 2;
            this.lab1.Text = "Search:";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(483, 79);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(692, 22);
            this.search.TabIndex = 3;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn1.Location = new System.Drawing.Point(1141, 23);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "Back";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logoutbtn.Location = new System.Drawing.Point(703, 683);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(175, 31);
            this.logoutbtn.TabIndex = 5;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // viewbtn
            // 
            this.viewbtn.BackColor = System.Drawing.Color.White;
            this.viewbtn.Location = new System.Drawing.Point(417, 578);
            this.viewbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(339, 23);
            this.viewbtn.TabIndex = 6;
            this.viewbtn.Text = "View";
            this.viewbtn.UseVisualStyleBackColor = false;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // totalbtn
            // 
            this.totalbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.totalbtn.Location = new System.Drawing.Point(899, 578);
            this.totalbtn.Name = "totalbtn";
            this.totalbtn.Size = new System.Drawing.Size(75, 23);
            this.totalbtn.TabIndex = 7;
            this.totalbtn.Text = "Total";
            this.totalbtn.UseVisualStyleBackColor = false;
            this.totalbtn.Click += new System.EventHandler(this.totalbtn_Click);
            // 
            // totalsum
            // 
            this.totalsum.BackColor = System.Drawing.Color.DimGray;
            this.totalsum.Location = new System.Drawing.Point(1064, 578);
            this.totalsum.Name = "totalsum";
            this.totalsum.Size = new System.Drawing.Size(100, 23);
            this.totalsum.TabIndex = 8;
            // 
            // StoredInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1239, 743);
            this.Controls.Add(this.totalsum);
            this.Controls.Add(this.totalbtn);
            this.Controls.Add(this.viewbtn);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.inventorytable);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StoredInventory";
            this.Text = "StoredInventory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onformclose);
            ((System.ComponentModel.ISupportInitialize)(this.inventorytable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView inventorytable;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Button viewbtn;
        private System.Windows.Forms.Button totalbtn;
        private System.Windows.Forms.Label totalsum;
    }
}