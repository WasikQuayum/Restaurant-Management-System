using Entity;
using Repository;
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
    public partial class Loginpage : Form
    {
        internal LoginRepo lr;
        public Loginpage()
        {
            InitializeComponent();
            lr = new LoginRepo();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string id = idtb.Text;
            string password = passtb.Text;
            Login l = lr.GetUser(id, password);

            if (l != null)
            {//MessageBox.Show("Valid");
                if (l.Role == 1)
                {
                    ManagerHompage hp = new ManagerHompage(l);
                    this.Visible = false;
                    hp.Visible = true;
                }
                else
                {
                    if (l.Role == 2)
                    {
                        Accounts ac = new Accounts(l);
                        this.Visible = false;
                        ac.Visible = true;

                    }
                    else
                    {
                        Chef cf = new Chef(l);
                        this.Visible = false;
                        cf.Visible = true;
                    }
                }

            }
            else
            {
                MessageBox.Show("Invalid Id or Password");
            }
        }

        private void On_form_close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
