namespace ApplicationLayer
{
    partial class Order
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
            this.bload = new System.Windows.Forms.Button();
            this.ordercombo = new System.Windows.Forms.ComboBox();
            this.lab1 = new System.Windows.Forms.Label();
            this.rejectbtn = new System.Windows.Forms.Button();
            this.acceptbtn = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.corder = new System.Windows.Forms.DataGridView();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.corder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.bload);
            this.panel1.Controls.Add(this.ordercombo);
            this.panel1.Controls.Add(this.lab1);
            this.panel1.Location = new System.Drawing.Point(1, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 602);
            this.panel1.TabIndex = 0;
            // 
            // bload
            // 
            this.bload.BackColor = System.Drawing.Color.White;
            this.bload.Location = new System.Drawing.Point(136, 173);
            this.bload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bload.Name = "bload";
            this.bload.Size = new System.Drawing.Size(60, 33);
            this.bload.TabIndex = 6;
            this.bload.Text = "Load";
            this.bload.UseVisualStyleBackColor = false;
            this.bload.Click += new System.EventHandler(this.bload_Click);
            // 
            // ordercombo
            // 
            this.ordercombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ordercombo.FormattingEnabled = true;
            this.ordercombo.Location = new System.Drawing.Point(75, 147);
            this.ordercombo.Name = "ordercombo";
            this.ordercombo.Size = new System.Drawing.Size(121, 21);
            this.ordercombo.TabIndex = 5;
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(20, 150);
            this.lab1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(50, 13);
            this.lab1.TabIndex = 3;
            this.lab1.Text = "Order ID:";
            // 
            // rejectbtn
            // 
            this.rejectbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rejectbtn.Location = new System.Drawing.Point(735, 495);
            this.rejectbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rejectbtn.Name = "rejectbtn";
            this.rejectbtn.Size = new System.Drawing.Size(120, 33);
            this.rejectbtn.TabIndex = 4;
            this.rejectbtn.Text = "Reject";
            this.rejectbtn.UseVisualStyleBackColor = false;
            this.rejectbtn.Click += new System.EventHandler(this.rejectbtn_Click);
            // 
            // acceptbtn
            // 
            this.acceptbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.acceptbtn.Location = new System.Drawing.Point(606, 495);
            this.acceptbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acceptbtn.Name = "acceptbtn";
            this.acceptbtn.Size = new System.Drawing.Size(116, 33);
            this.acceptbtn.TabIndex = 3;
            this.acceptbtn.Text = "Accept";
            this.acceptbtn.UseVisualStyleBackColor = false;
            this.acceptbtn.Click += new System.EventHandler(this.acceptbtn_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn1.Location = new System.Drawing.Point(836, 37);
            this.btn1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(62, 26);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Back";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // corder
            // 
            this.corder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.corder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.corder.Location = new System.Drawing.Point(342, 106);
            this.corder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.corder.Name = "corder";
            this.corder.RowTemplate.Height = 24;
            this.corder.Size = new System.Drawing.Size(513, 385);
            this.corder.TabIndex = 2;
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logoutbtn.Location = new System.Drawing.Point(517, 563);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(163, 22);
            this.logoutbtn.TabIndex = 5;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(929, 604);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.corder);
            this.Controls.Add(this.rejectbtn);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.acceptbtn);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Order";
            this.Text = "Order";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.on_form_close);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.corder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button rejectbtn;
        private System.Windows.Forms.Button acceptbtn;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.DataGridView corder;
        private System.Windows.Forms.ComboBox ordercombo;
        private System.Windows.Forms.Button bload;
        private System.Windows.Forms.Button logoutbtn;
    }
}