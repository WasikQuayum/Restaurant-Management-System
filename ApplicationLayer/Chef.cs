using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Entity;

namespace ApplicationLayer
{
    
    public partial class Chef : Form
    {
        Login l = new Login();
        public Chef(Login l)
        {
            this.l = l;
            
            InitializeComponent();
            idl.Text = "" + l.Id;
            this.welcome.Text = "Welcome";
        }

        public Chef()
        {
            InitializeComponent();
            
        }
      
       

        private void btn3_Click(object sender, EventArgs e)
        {
            Loginpage f = new Loginpage();
            f.Visible = true;
            this.Visible = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            CreateIngredientList cl = new CreateIngredientList();
            cl.Visible = true;
            this.Visible = false;
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.Visible = true;
            this.Visible = false;
        }
        

        private void onformclose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}
