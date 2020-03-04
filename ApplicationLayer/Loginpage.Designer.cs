namespace ApplicationLayer
{
    partial class Loginpage
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
            this.wellcomelab = new System.Windows.Forms.Label();
            this.passtb = new System.Windows.Forms.TextBox();
            this.idtb = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.passlab = new System.Windows.Forms.Label();
            this.uselab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.wellcomelab);
            this.panel1.Controls.Add(this.passtb);
            this.panel1.Controls.Add(this.idtb);
            this.panel1.Controls.Add(this.loginbtn);
            this.panel1.Controls.Add(this.passlab);
            this.panel1.Controls.Add(this.uselab);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 602);
            this.panel1.TabIndex = 0;
            // 
            // wellcomelab
            // 
            this.wellcomelab.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wellcomelab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wellcomelab.Location = new System.Drawing.Point(68, 44);
            this.wellcomelab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wellcomelab.Name = "wellcomelab";
            this.wellcomelab.Size = new System.Drawing.Size(162, 46);
            this.wellcomelab.TabIndex = 1;
            this.wellcomelab.Text = "Welcome";
            this.wellcomelab.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // passtb
            // 
            this.passtb.Location = new System.Drawing.Point(85, 267);
            this.passtb.Margin = new System.Windows.Forms.Padding(2);
            this.passtb.Name = "passtb";
            this.passtb.PasswordChar = '*';
            this.passtb.Size = new System.Drawing.Size(134, 20);
            this.passtb.TabIndex = 3;
            // 
            // idtb
            // 
            this.idtb.Location = new System.Drawing.Point(85, 180);
            this.idtb.Margin = new System.Windows.Forms.Padding(2);
            this.idtb.Name = "idtb";
            this.idtb.Size = new System.Drawing.Size(138, 20);
            this.idtb.TabIndex = 1;
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.White;
            this.loginbtn.Location = new System.Drawing.Point(68, 342);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(2);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(56, 23);
            this.loginbtn.TabIndex = 1;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // passlab
            // 
            this.passlab.Location = new System.Drawing.Point(9, 267);
            this.passlab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passlab.Name = "passlab";
            this.passlab.Size = new System.Drawing.Size(71, 18);
            this.passlab.TabIndex = 2;
            this.passlab.Text = "Password: ";
            this.passlab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uselab
            // 
            this.uselab.Location = new System.Drawing.Point(13, 182);
            this.uselab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uselab.Name = "uselab";
            this.uselab.Size = new System.Drawing.Size(68, 21);
            this.uselab.TabIndex = 1;
            this.uselab.Text = "User Id: ";
            this.uselab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(237, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "To Restaurant Management System";
            // 
            // Loginpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(929, 604);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Loginpage";
            this.Text = "Login Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.On_form_close);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label wellcomelab;
        private System.Windows.Forms.TextBox passtb;
        private System.Windows.Forms.TextBox idtb;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label passlab;
        private System.Windows.Forms.Label uselab;
        private System.Windows.Forms.Label label1;
    }
}

