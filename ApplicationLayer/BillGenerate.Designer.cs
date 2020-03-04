namespace ApplicationLayer
{
    partial class BillGenerate
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
            this.combo = new System.Windows.Forms.ComboBox();
            this.bload = new System.Windows.Forms.Button();
            this.lab1 = new System.Windows.Forms.Label();
            this.bprint = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.billtable = new System.Windows.Forms.DataGridView();
            this.logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billtable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.combo);
            this.panel1.Controls.Add(this.bload);
            this.panel1.Controls.Add(this.lab1);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 741);
            this.panel1.TabIndex = 0;
            // 
            // combo
            // 
            this.combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(99, 146);
            this.combo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(199, 24);
            this.combo.TabIndex = 5;
            // 
            // bload
            // 
            this.bload.BackColor = System.Drawing.Color.White;
            this.bload.Location = new System.Drawing.Point(191, 190);
            this.bload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bload.Name = "bload";
            this.bload.Size = new System.Drawing.Size(108, 25);
            this.bload.TabIndex = 1;
            this.bload.Text = "Load";
            this.bload.UseVisualStyleBackColor = false;
            this.bload.Click += new System.EventHandler(this.bload_Click);
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(9, 153);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(64, 17);
            this.lab1.TabIndex = 1;
            this.lab1.Text = "Order Id:";
            // 
            // bprint
            // 
            this.bprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bprint.Location = new System.Drawing.Point(581, 574);
            this.bprint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bprint.Name = "bprint";
            this.bprint.Size = new System.Drawing.Size(389, 34);
            this.bprint.TabIndex = 2;
            this.bprint.Text = "Print";
            this.bprint.UseVisualStyleBackColor = false;
            this.bprint.Click += new System.EventHandler(this.print_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn3.Location = new System.Drawing.Point(1149, 30);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "Back";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // billtable
            // 
            this.billtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billtable.Location = new System.Drawing.Point(331, 87);
            this.billtable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.billtable.Name = "billtable";
            this.billtable.Size = new System.Drawing.Size(903, 458);
            this.billtable.TabIndex = 4;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logout.Location = new System.Drawing.Point(663, 699);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(215, 32);
            this.logout.TabIndex = 5;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // BillGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1239, 743);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.billtable);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.bprint);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BillGenerate";
            this.Text = "BillGenerate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onformclose);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billtable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bload;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Button bprint;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.DataGridView billtable;
        private System.Windows.Forms.Button logout;
    }
}