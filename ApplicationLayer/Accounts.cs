using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApplicationLayer
{
    public partial class Accounts : Form
    {
        Login l = new Login();
        public Accounts(Login l)
        {
            this.l = l;
            
            InitializeComponent();
            idl.Text = "" + l.Id;
            this.welcome.Text = "Welcome";
        }

        public Accounts()
        {
            InitializeComponent();
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Loginpage f = new Loginpage();
            f.Visible = true;
            this.Visible = false;
        }

        private void btn4_Click(object sender, EventArgs e)//take order
        {
            TakeOrder to = new TakeOrder();
            to.Visible = true;
            this.Visible = false;
        }

        private void btn1_Click(object sender, EventArgs e)//Bill Genarate Gui
        {
            BillGenerate bg = new BillGenerate(l);
            bg.Visible = true;
            this.Visible = false;
        }

        private void btn2_Click(object sender, EventArgs e)//Ingredient bill
        {
            IngredientBill ib = new IngredientBill();
            ib.Visible = true;
            this.Visible = false;
        }
        

        private void onformclose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void borderstatus_Click(object sender, EventArgs e)
        {
            Orderstatus os = new Orderstatus();
            os.Visible = true;
            this.Visible = false;

        }

    }
}
