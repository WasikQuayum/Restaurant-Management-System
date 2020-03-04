namespace ApplicationLayer
{
    partial class CreateIngredientList
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
            this.iupdate = new System.Windows.Forms.Button();
            this.idlabel = new System.Windows.Forms.Label();
            this.idtb = new System.Windows.Forms.TextBox();
            this.qtype = new System.Windows.Forms.ComboBox();
            this.del = new System.Windows.Forms.Button();
            this.tq = new System.Windows.Forms.TextBox();
            this.lab2 = new System.Windows.Forms.Label();
            this.badd = new System.Windows.Forms.Button();
            this.tname = new System.Windows.Forms.TextBox();
            this.lab1 = new System.Windows.Forms.Label();
            this.bupdate = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.tbl = new System.Windows.Forms.DataGridView();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.iupdate);
            this.panel1.Controls.Add(this.idlabel);
            this.panel1.Controls.Add(this.idtb);
            this.panel1.Controls.Add(this.qtype);
            this.panel1.Controls.Add(this.del);
            this.panel1.Controls.Add(this.tq);
            this.panel1.Controls.Add(this.lab2);
            this.panel1.Controls.Add(this.badd);
            this.panel1.Controls.Add(this.tname);
            this.panel1.Controls.Add(this.lab1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 741);
            this.panel1.TabIndex = 0;
            // 
            // iupdate
            // 
            this.iupdate.BackColor = System.Drawing.Color.White;
            this.iupdate.Enabled = false;
            this.iupdate.Location = new System.Drawing.Point(189, 302);
            this.iupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iupdate.Name = "iupdate";
            this.iupdate.Size = new System.Drawing.Size(119, 23);
            this.iupdate.TabIndex = 8;
            this.iupdate.Text = "Update";
            this.iupdate.UseVisualStyleBackColor = false;
            this.iupdate.Click += new System.EventHandler(this.iupdate_Click);
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(16, 132);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(86, 17);
            this.idlabel.TabIndex = 7;
            this.idlabel.Text = "Ingredient Id";
            // 
            // idtb
            // 
            this.idtb.Enabled = false;
            this.idtb.Location = new System.Drawing.Point(139, 128);
            this.idtb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idtb.Name = "idtb";
            this.idtb.ReadOnly = true;
            this.idtb.Size = new System.Drawing.Size(141, 22);
            this.idtb.TabIndex = 6;
            // 
            // qtype
            // 
            this.qtype.FormattingEnabled = true;
            this.qtype.Items.AddRange(new object[] {
            "Kg",
            "Piece"});
            this.qtype.Location = new System.Drawing.Point(184, 234);
            this.qtype.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.qtype.Name = "qtype";
            this.qtype.Size = new System.Drawing.Size(97, 24);
            this.qtype.TabIndex = 5;
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.White;
            this.del.Enabled = false;
            this.del.Location = new System.Drawing.Point(109, 302);
            this.del.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 2;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // tq
            // 
            this.tq.Location = new System.Drawing.Point(139, 234);
            this.tq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tq.Name = "tq";
            this.tq.Size = new System.Drawing.Size(37, 22);
            this.tq.TabIndex = 4;
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(15, 234);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(65, 17);
            this.lab2.TabIndex = 3;
            this.lab2.Text = "Quantity:";
            // 
            // badd
            // 
            this.badd.BackColor = System.Drawing.Color.White;
            this.badd.Location = new System.Drawing.Point(29, 302);
            this.badd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(75, 23);
            this.badd.TabIndex = 1;
            this.badd.Text = "Add";
            this.badd.UseVisualStyleBackColor = false;
            this.badd.Click += new System.EventHandler(this.add_Click);
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(139, 174);
            this.tname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(141, 22);
            this.tname.TabIndex = 2;
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(15, 177);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(116, 17);
            this.lab1.TabIndex = 1;
            this.lab1.Text = "Ingredient Name:";
            // 
            // bupdate
            // 
            this.bupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bupdate.Location = new System.Drawing.Point(1021, 648);
            this.bupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bupdate.Name = "bupdate";
            this.bupdate.Size = new System.Drawing.Size(119, 39);
            this.bupdate.TabIndex = 3;
            this.bupdate.Text = "Update";
            this.bupdate.UseVisualStyleBackColor = false;
            this.bupdate.Click += new System.EventHandler(this.bupdate_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn4.Location = new System.Drawing.Point(1128, 11);
            this.btn4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "Back";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // tbl
            // 
            this.tbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl.Location = new System.Drawing.Point(397, 77);
            this.tbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbl.Name = "tbl";
            this.tbl.ReadOnly = true;
            this.tbl.RowTemplate.Height = 24;
            this.tbl.Size = new System.Drawing.Size(743, 556);
            this.tbl.TabIndex = 5;
            this.tbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cc);
            this.tbl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_CellContentClick);
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logoutbtn.Location = new System.Drawing.Point(656, 700);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(207, 31);
            this.logoutbtn.TabIndex = 6;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // CreateIngredientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1239, 743);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.tbl);
            this.Controls.Add(this.bupdate);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateIngredientList";
            this.Text = "Create Ingredient List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onformclose);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button bupdate;
        private System.Windows.Forms.TextBox tq;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.DataGridView tbl;
        private System.Windows.Forms.Button iupdate;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.TextBox idtb;
        private System.Windows.Forms.ComboBox qtype;
        private System.Windows.Forms.Button logoutbtn;
    }
}