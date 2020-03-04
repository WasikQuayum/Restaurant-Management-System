namespace ApplicationLayer
{
    partial class Fixcostl
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
            this.idtb = new System.Windows.Forms.TextBox();
            this.idlb = new System.Windows.Forms.Label();
            this.del = new System.Windows.Forms.Button();
            this.badd = new System.Windows.Forms.Button();
            this.titletb = new System.Windows.Forms.TextBox();
            this.idlabel = new System.Windows.Forms.Label();
            this.pricetb = new System.Windows.Forms.TextBox();
            this.lab1 = new System.Windows.Forms.Label();
            this.tbl = new System.Windows.Forms.DataGridView();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.backb = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.idtb);
            this.panel1.Controls.Add(this.idlb);
            this.panel1.Controls.Add(this.del);
            this.panel1.Controls.Add(this.badd);
            this.panel1.Controls.Add(this.titletb);
            this.panel1.Controls.Add(this.idlabel);
            this.panel1.Controls.Add(this.pricetb);
            this.panel1.Controls.Add(this.lab1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 602);
            this.panel1.TabIndex = 1;
            // 
            // idtb
            // 
            this.idtb.Enabled = false;
            this.idtb.Location = new System.Drawing.Point(101, 61);
            this.idtb.Margin = new System.Windows.Forms.Padding(2);
            this.idtb.Name = "idtb";
            this.idtb.Size = new System.Drawing.Size(107, 20);
            this.idtb.TabIndex = 16;
            // 
            // idlb
            // 
            this.idlb.AutoSize = true;
            this.idlb.Location = new System.Drawing.Point(9, 68);
            this.idlb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idlb.Name = "idlb";
            this.idlb.Size = new System.Drawing.Size(16, 13);
            this.idlb.TabIndex = 15;
            this.idlb.Text = "Id";
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.White;
            this.del.Enabled = false;
            this.del.Location = new System.Drawing.Point(110, 182);
            this.del.Margin = new System.Windows.Forms.Padding(2);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(56, 19);
            this.del.TabIndex = 14;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // badd
            // 
            this.badd.BackColor = System.Drawing.Color.White;
            this.badd.Location = new System.Drawing.Point(50, 182);
            this.badd.Margin = new System.Windows.Forms.Padding(2);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(56, 19);
            this.badd.TabIndex = 13;
            this.badd.Text = "Add";
            this.badd.UseVisualStyleBackColor = false;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // titletb
            // 
            this.titletb.Location = new System.Drawing.Point(101, 97);
            this.titletb.Margin = new System.Windows.Forms.Padding(2);
            this.titletb.Name = "titletb";
            this.titletb.Size = new System.Drawing.Size(107, 20);
            this.titletb.TabIndex = 12;
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(9, 100);
            this.idlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(27, 13);
            this.idlabel.TabIndex = 11;
            this.idlabel.Text = "Title";
            // 
            // pricetb
            // 
            this.pricetb.Location = new System.Drawing.Point(101, 134);
            this.pricetb.Margin = new System.Windows.Forms.Padding(2);
            this.pricetb.Name = "pricetb";
            this.pricetb.Size = new System.Drawing.Size(107, 20);
            this.pricetb.TabIndex = 9;
            this.pricetb.TextChanged += new System.EventHandler(this.ch);
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(8, 137);
            this.lab1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(28, 13);
            this.lab1.TabIndex = 8;
            this.lab1.Text = "Cost";
            // 
            // tbl
            // 
            this.tbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl.Location = new System.Drawing.Point(248, 81);
            this.tbl.Margin = new System.Windows.Forms.Padding(2);
            this.tbl.Name = "tbl";
            this.tbl.ReadOnly = true;
            this.tbl.RowTemplate.Height = 24;
            this.tbl.Size = new System.Drawing.Size(670, 432);
            this.tbl.TabIndex = 6;
            this.tbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblclick);
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logoutbtn.Location = new System.Drawing.Point(574, 571);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(2);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(137, 22);
            this.logoutbtn.TabIndex = 7;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logout);
            // 
            // backb
            // 
            this.backb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.backb.Location = new System.Drawing.Point(853, 25);
            this.backb.Margin = new System.Windows.Forms.Padding(2);
            this.backb.Name = "backb";
            this.backb.Size = new System.Drawing.Size(56, 19);
            this.backb.TabIndex = 8;
            this.backb.Text = "Back";
            this.backb.UseVisualStyleBackColor = false;
            this.backb.Click += new System.EventHandler(this.back_Click);
            // 
            // Fixcostl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 604);
            this.Controls.Add(this.backb);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.tbl);
            this.Controls.Add(this.panel1);
            this.Name = "Fixcostl";
            this.Text = "Fixcost";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onformclose);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox titletb;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.TextBox pricetb;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.DataGridView tbl;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Button backb;
        private System.Windows.Forms.TextBox idtb;
        private System.Windows.Forms.Label idlb;

    }
}