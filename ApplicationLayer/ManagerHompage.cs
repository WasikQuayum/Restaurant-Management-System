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
    public partial class ManagerHompage : Form
    {
        Login l = new Login();
        public ManagerHompage()
        {
            
            InitializeComponent();
            
        }
        public ManagerHompage(Login l)
        {
            this.l = l;
            
            InitializeComponent();
            idl.Text = "" + l.Id;
            this.welcome.Text = "Welcome";
        }



        private void btn2_Click(object sender, EventArgs e)
        {
            EmployeeManagement epm = new EmployeeManagement(l);
            this.Visible = false;
            epm.Visible = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            CreateMenue cm = new CreateMenue();
            cm.Visible = true;
            this.Visible = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Loginpage f = new Loginpage();
            this.Visible = false;
            f.Visible = true;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Food fd = new Food();
            fd.Visible = true;
            this.Visible = false;
        }

        private void btn5_Click(object sender, EventArgs e)//Manager can see the inventory List
        {
            StoredInventory si = new StoredInventory();
            si.Visible = true;
            this.Visible = false;

        }

        private void btn8_Click(object sender, EventArgs e)//Report generate button
        {
            Report rp = new Report();
            rp.Visible = true;
            this.Visible = false;

        }
        private void On_form_close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       

        private void btn1_Click(object sender, EventArgs e)
        {
            ManagerOrderStatus mos = new ManagerOrderStatus();
            mos.Visible = true;
            this.Visible = false;
        }

        private void onformclose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

       

        private void fxcst_Click(object sender, EventArgs e)
        {
            Fixcostl fx = new Fixcostl();
            fx.Visible = true;
            this.Visible = false;

        }
    }
}
