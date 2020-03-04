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
    public partial class BillGenerate : Form
    {
        DatabaseConnectionClass dcc;
        List<string> ac = new List<string>();
        List<Orderitem> listoforderitem = new List<Orderitem>();
        string selected;
        Login l = new Login();
        public BillGenerate(Login l)
        {
            this.l=l;
            dcc = new DatabaseConnectionClass();
            InitializeComponent();
            Loadorder();
        }

        void Loadorder()
        {
            string query = "SELECT * from TOrderitem";
            try
            {
                dcc.ConnectWithDB();
                SqlDataReader sdr = dcc.GetData(query);
                while (sdr.Read())
                {
                    string a;
                    a = sdr["TOrderid"].ToString();

                    if (!ac.Contains(a) && ((sdr["TStatus"].ToString()).Equals("accepted")))
                        ac.Add(a);
                }

            }
            catch (Exception exp)
            {
            }
            finally
            {
                dcc.CloseConnection();
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = ac;

            combo.DataSource = bs;

        }




        private void btn3_Click(object sender, EventArgs e)//back to account 
        {
            Accounts acc = new Accounts();
            acc.Visible = true;
            this.Visible = false;
        }

        private void onformclose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bload_Click(object sender, EventArgs e)
        {
            selected = this.combo.GetItemText(this.combo.SelectedItem);
            if (ac.Contains(selected))
            {
                listoforderitem.Clear();
                string query = "SELECT * FROM TOrderitem ";
                try
                {
                    dcc.ConnectWithDB();
                    SqlDataReader sdr = dcc.GetData(query);
                    while (sdr.Read())
                    {
                        if ((sdr["TOrderid"].ToString()).Equals(selected))
                        {
                            Orderitem od = new Orderitem();
                            od.Foodid = sdr["TFoodid"].ToString();
                            od.Foodname = sdr["TFoodname"].ToString();
                            od.Quantity = Convert.ToInt32(sdr["TQuantity"]);
                            od.Totalprice = Convert.ToDouble(sdr["TTotalprice"]);
                            listoforderitem.Add(od);
                        }
                    }

                }
                catch (Exception exp)
                {
                }
                finally
                {
                    dcc.CloseConnection();
                }
                BindingSource bs = new BindingSource();
                bs.DataSource = listoforderitem;
                billtable.DataSource = bs;

            }
            else
            {
                billtable.DataSource = null;
                listoforderitem.Clear();
                MessageBox.Show("ID not present \nCheck for order status");
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            if (listoforderitem.Any())
            {
                PrintRepo rp = new PrintRepo(l);
                rp.gpdf(listoforderitem, selected);
                MessageBox.Show("Pdf generated");

            }
            else
                MessageBox.Show("select something to print first");
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Loginpage lp = new Loginpage();
            lp.Visible = true;
            this.Visible = false;
        }
    }
}
