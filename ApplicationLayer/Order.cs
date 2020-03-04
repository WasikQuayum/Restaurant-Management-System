using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationLayer
{
    public partial class Order : Form
    {
        DatabaseConnectionClass dcc;
        List<string> ac=new List<string>();
        List<Orderitem> listoforderitem = new List<Orderitem>();
        string selected;

        public Order()
        {
            dcc = new DatabaseConnectionClass();
            InitializeComponent();
            Loadorder();
        }

        private void btn1_Click(object sender, EventArgs e)//back btn
        {
            Chef c = new Chef();
            c.Visible = true;
            this.Visible = false;
        }

        void Loadorder()
        {
            OrderRepo o=new OrderRepo();
            ac = o.Getidlist();
            BindingSource bs = new BindingSource();
            bs.DataSource = ac;

            ordercombo.DataSource = bs;

        }

      

        private void bload_Click(object sender, EventArgs e)
        {
            OrderRepo o=new OrderRepo();
            selected = this.ordercombo.GetItemText(this.ordercombo.SelectedItem);
            listoforderitem.Clear();
            listoforderitem = o.Getall(selected);
            BindingSource bs = new BindingSource();
            bs.DataSource = listoforderitem;
            corder.DataSource = bs;
            
        }

        private void on_form_close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void acceptbtn_Click(object sender, EventArgs e)
        {
            if (!(selected == null))
            {
                OrderRepo o = new OrderRepo();
                o.setstatus(selected, "accepted");
                ordercombo.DataSource = null;
                ac.Clear();
                corder.DataSource = null;
              
                Loadorder();
                
                

               
            }
        }

        private void rejectbtn_Click(object sender, EventArgs e)
        {
            if (!(selected == null))
            {
                OrderRepo o = new OrderRepo();
                o.setstatus(selected, "rejected");
                ordercombo.DataSource = null;
                ac.Clear();
                corder.DataSource = null;
               
                Loadorder();

            }
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Loginpage lp = new Loginpage();
            lp.Visible = true;
            this.Visible = false;
        }
    }
}
