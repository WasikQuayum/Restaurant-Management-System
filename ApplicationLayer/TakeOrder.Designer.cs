namespace ApplicationLayer
{
    partial class TakeOrder
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
            this.FoodItemlb = new System.Windows.Forms.Label();
            this.tbfooditem = new System.Windows.Forms.DataGridView();
            this.btn1 = new System.Windows.Forms.Button();
            this.ordertable = new System.Windows.Forms.DataGridView();
            this.btkconfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ltbill = new System.Windows.Forms.Label();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbfooditem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.FoodItemlb);
            this.panel1.Controls.Add(this.tbfooditem);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 602);
            this.panel1.TabIndex = 0;
            // 
            // FoodItemlb
            // 
            this.FoodItemlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodItemlb.Location = new System.Drawing.Point(58, 115);
            this.FoodItemlb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FoodItemlb.Name = "FoodItemlb";
            this.FoodItemlb.Size = new System.Drawing.Size(118, 26);
            this.FoodItemlb.TabIndex = 1;
            this.FoodItemlb.Text = "Food Item";
            // 
            // tbfooditem
            // 
            this.tbfooditem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbfooditem.Location = new System.Drawing.Point(2, 143);
            this.tbfooditem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbfooditem.Name = "tbfooditem";
            this.tbfooditem.ReadOnly = true;
            this.tbfooditem.RowTemplate.Height = 24;
            this.tbfooditem.Size = new System.Drawing.Size(229, 271);
            this.tbfooditem.TabIndex = 1;
            this.tbfooditem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbcc);
            this.tbfooditem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbfooditem_CellContentClick);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn1.Location = new System.Drawing.Point(848, 25);
            this.btn1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(56, 19);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "Back";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // ordertable
            // 
            this.ordertable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordertable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordertable.Location = new System.Drawing.Point(246, 69);
            this.ordertable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ordertable.Name = "ordertable";
            this.ordertable.ReadOnly = true;
            this.ordertable.RowTemplate.Height = 24;
            this.ordertable.Size = new System.Drawing.Size(680, 344);
            this.ordertable.TabIndex = 5;
            this.ordertable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordcc);
            this.ordertable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordertable_CellContentClick);
            // 
            // btkconfirm
            // 
            this.btkconfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btkconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btkconfirm.Location = new System.Drawing.Point(684, 417);
            this.btkconfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btkconfirm.Name = "btkconfirm";
            this.btkconfirm.Size = new System.Drawing.Size(242, 51);
            this.btkconfirm.TabIndex = 6;
            this.btkconfirm.Text = "Confirm";
            this.btkconfirm.UseVisualStyleBackColor = false;
            this.btkconfirm.Click += new System.EventHandler(this.btkconfirm_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(714, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total Bill:";
            // 
            // ltbill
            // 
            this.ltbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbill.Location = new System.Drawing.Point(823, 377);
            this.ltbill.Name = "ltbill";
            this.ltbill.Size = new System.Drawing.Size(103, 34);
            this.ltbill.TabIndex = 8;
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logoutbtn.Location = new System.Drawing.Point(466, 566);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(174, 28);
            this.logoutbtn.TabIndex = 9;
            this.logoutbtn.Text = "Log out";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // TakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(929, 604);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.ltbill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btkconfirm);
            this.Controls.Add(this.ordertable);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TakeOrder";
            this.Text = "TakeOrder";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.On_form_close);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbfooditem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label FoodItemlb;
        private System.Windows.Forms.DataGridView tbfooditem;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.DataGridView ordertable;
        private System.Windows.Forms.Button btkconfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ltbill;
        private System.Windows.Forms.Button logoutbtn;
    }
}