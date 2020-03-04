using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationLayer
{
    public partial class ManagerOrderStatus : Form
    {
        public ManagerOrderStatus()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            ManagerHompage mh = new ManagerHompage();
            this.Visible = false;
            mh.Visible = true;

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Loginpage lp = new Loginpage();
            lp.Visible = true;
            this.Visible = false;
        }

        private void ManagerOrderStatus_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
