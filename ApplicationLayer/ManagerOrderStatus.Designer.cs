namespace ApplicationLayer
{
    partial class ManagerOrderStatus
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
            this.Orderstatusbill = new System.Windows.Forms.DataGridView();
            this.viewbtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Orderstatusbill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 604);
            this.panel1.TabIndex = 0;
            // 
            // Orderstatusbill
            // 
            this.Orderstatusbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Orderstatusbill.Location = new System.Drawing.Point(337, 86);
            this.Orderstatusbill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Orderstatusbill.Name = "Orderstatusbill";
            this.Orderstatusbill.RowTemplate.Height = 24;
            this.Orderstatusbill.Size = new System.Drawing.Size(521, 316);
            this.Orderstatusbill.TabIndex = 1;
            // 
            // viewbtn
            // 
            this.viewbtn.BackColor = System.Drawing.Color.White;
            this.viewbtn.Location = new System.Drawing.Point(494, 436);
            this.viewbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(221, 19);
            this.viewbtn.TabIndex = 2;
            this.viewbtn.Text = "View";
            this.viewbtn.UseVisualStyleBackColor = false;
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logoutbtn.Location = new System.Drawing.Point(541, 554);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(136, 24);
            this.logoutbtn.TabIndex = 3;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.backbtn.Location = new System.Drawing.Point(832, 24);
            this.backbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(56, 19);
            this.backbtn.TabIndex = 4;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // ManagerOrderStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(929, 604);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.viewbtn);
            this.Controls.Add(this.Orderstatusbill);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManagerOrderStatus";
            this.Text = "ManagerOrderStatus";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerOrderStatus_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Orderstatusbill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Orderstatusbill;
        private System.Windows.Forms.Button viewbtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Button backbtn;
    }
}