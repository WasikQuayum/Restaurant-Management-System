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

    public partial class TakeOrder : Form
    {
        
        List<Fooditem> listoffooditem = new List<Fooditem>();
        List<Orderitem> listoforderitem = new List<Orderitem>();
        double tbill=0;
        public TakeOrder()
        {
            InitializeComponent();
            foodload();
        }

        private void btn1_Click(object sender, EventArgs e)///back from take order
        {
            Accounts acc = new Accounts();
            acc.Visible = true;
            this.Visible = false;
        }

        public void foodload()
        {
            FooditemRepo f=new FooditemRepo();

            listoffooditem = f.GetAllFooditem();

            tbfooditem.DataSource = listoffooditem;
        }

        private void tbfooditem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            bool flag = false;
            Orderitem od = new Orderitem();
            od.Foodid = tbfooditem.Rows[e.RowIndex].Cells[0].Value.ToString();
            od.Foodname = tbfooditem.Rows[e.RowIndex].Cells[1].Value.ToString();
            od.Totalprice = Convert.ToDouble(tbfooditem.Rows[e.RowIndex].Cells[2].Value.ToString());

            for (int i = 0; i < listoforderitem.Count; i++)
            {
                if ((listoforderitem[i].Foodid).Equals(od.Foodid))
                {
                    listoforderitem[i].Totalprice = listoforderitem[i].Totalprice + od.Totalprice;
                    listoforderitem[i].Quantity = listoforderitem[i].Quantity + 1;
                    flag = true;
                }
            }
            if (!flag)
            {
                od.Quantity = 1;
                listoforderitem.Add(od);

            }
            tbill = 0;

            for (int i = 0; i < listoforderitem.Count; i++)
            {
                tbill = tbill + listoforderitem[i].Totalprice;
            }
            ltbill.Text = tbill + "";
            BindingSource bs = new BindingSource();
            bs.DataSource=listoforderitem;
            this.ordertable.DataSource = bs;
        }





        

        private void ordertable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Orderitem od = new Orderitem();
            od.Foodid = ordertable.Rows[e.RowIndex].Cells[0].Value.ToString();
            od.Foodname = ordertable.Rows[e.RowIndex].Cells[1].Value.ToString();
            od.Quantity = Convert.ToInt32(ordertable.Rows[e.RowIndex].Cells[2].Value);
            od.Totalprice = Convert.ToDouble(ordertable.Rows[e.RowIndex].Cells[3].Value.ToString());

            if (od.Quantity == 1)
            {
                for (int i = 0; i < listoforderitem.Count; i++)
                {
                    if ((listoforderitem[i].Foodid).Equals(od.Foodid))
                    {
                        listoforderitem.Remove(listoforderitem[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < listoforderitem.Count; i++)
                {
                    if ((listoforderitem[i].Foodid).Equals(od.Foodid))
                    {
                        listoforderitem[i].Totalprice = listoforderitem[i].Totalprice - (listoforderitem[i].Totalprice / listoforderitem[i].Quantity);
                        listoforderitem[i].Quantity = listoforderitem[i].Quantity - 1;
                    }
                }
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = listoforderitem;
            this.ordertable.DataSource = bs;
        }

        private void btkconfirm_Click(object sender, EventArgs e)
        {
            if (listoforderitem != null)
            {
                string message = "Foodname \t" + "Quantity \t" + "price";
                for (int i = 0; i < listoforderitem.Count; i++)
                {
                    message = message + "\n" + listoforderitem[i].Foodname + "\t" + listoforderitem[i].Quantity + "\t" + listoforderitem[i].Totalprice;
                }
                message = message + "\n \n Total Bill :" + tbill;
                DialogResult dialogResult = MessageBox.Show(message, "Are you Sure", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    OrderRepo o = new OrderRepo();
                    string r = o.Insertorder(listoforderitem);
                    MessageBox.Show("Order placed,wait for order confirmation.Order Id : "+r);
                }
            }
            else
                MessageBox.Show("No order placed,Place order first");


        }

        private void On_form_close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Loginpage lp = new Loginpage();
            lp.Visible = true;
            this.Visible = false;
        }

        private void tbcc(object sender, DataGridViewCellEventArgs e)
        {
            tbfooditem_CellContentClick(sender, e);
        }

        private void ordcc(object sender, DataGridViewCellEventArgs e)
        {
            ordertable_CellContentClick(sender, e);
        }

       

        }
    }

