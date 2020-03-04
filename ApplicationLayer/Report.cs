using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Repository;
using System.Data.SqlClient;

namespace ApplicationLayer
{
    public partial class Report : Form
    {
        DatabaseConnectionClass dcc;
        public Report()
        {
            InitializeComponent();
            dcc = new DatabaseConnectionClass();
        }

        private void back_Click(object sender, EventArgs e)
        {
            ManagerHompage m = new ManagerHompage();
            m.Visible = true;
            this.Visible = false;
        }

        private void onformclose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Total_Click(object sender, EventArgs e)
        {
            double income = 0, expense = 0, tfx = 0, tin = 0, tsal = 0 ;
            List<string> month = new List<string>();
            string ing="", fx="", or="", em="";

            for (int i = 1; i < 10; i++)
            {

                string query = "SELECT sum(TTotalprice) FROM TOrderitem  where tdate like '0" + i + "%' and TStatus='accepted'";
                try
                {
                    dcc.ConnectWithDB();
                    SqlDataReader sdr = dcc.GetData(query);
                    while (sdr.Read())
                    {
                        or = sdr[0].ToString();
                        income = income + Convert.ToDouble(or);
                        
                    }

                }
                catch (Exception exp)
                {
                    
                }
                finally
                {
                    dcc.CloseConnection();
                }

                ///////////////////////////////////////////////////

                query = "SELECT sum(InvPrice) FROM Ingredient  where date like '0" + i + "%'";
                try
                {
                    dcc.ConnectWithDB();
                    SqlDataReader sdr = dcc.GetData(query);
                    while (sdr.Read())
                    {
                        ing = sdr[0].ToString();
                        expense = expense + Convert.ToDouble(ing);
                        tin = tin + Convert.ToDouble(ing);

                    }

                }
                catch (Exception exp)
                {

                }
                finally
                {
                    dcc.CloseConnection();
                }

                /////////////////////////////////////////////////

                query = "SELECT sum(Fprice) FROM Fixcost  where Fdate like '0" + i + "%'";
                try
                {
                    dcc.ConnectWithDB();
                    SqlDataReader sdr = dcc.GetData(query);
                    while (sdr.Read())
                    {
                        fx = sdr[0].ToString();
                        expense = expense + Convert.ToDouble(fx);
                        tfx = tfx + Convert.ToDouble(fx);

                    }

                }
                catch (Exception exp)
                {

                }
                finally
                {
                    dcc.CloseConnection();
                }


                /////////////////////////////////////

                query = "SELECT sum(Salary) FROM Employees ";
                try
                {
                    dcc.ConnectWithDB();
                    SqlDataReader sdr = dcc.GetData(query);
                    while (sdr.Read())
                    {
                        if (!or.Equals(""))
                        {
                            em = sdr[0].ToString();
                            expense = expense + Convert.ToDouble(em);
                            tsal = tsal + Convert.ToDouble(em);
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

                /////////////////////////////////////
                chart1.Series["Ingredient"].Points.AddXY(i, ing);
                chart1.Series["Fixcost"].Points.AddXY(i, fx);
                chart1.Series["Salary"].Points.AddXY(i, em);
                chart1.Series["Income"].Points.AddXY(i, or);

            }


            //*********************************************//

            for (int i = 10; i < 13; i++)
            {
                string query = "SELECT sum(TTotalprice) FROM TOrderitem  where tdate like '" + i + "%' and TStatus='accepted'";
                try
                {
                    dcc.ConnectWithDB();
                    SqlDataReader sdr = dcc.GetData(query);
                    while (sdr.Read())
                    {
                        or = sdr[0].ToString();
                        income = income + Convert.ToDouble(or);

                    }

                }
                catch (Exception exp)
                {

                }
                finally
                {
                    dcc.CloseConnection();
                }

                ///////////////////////////////////////////////////

                query = "SELECT sum(InvPrice) FROM Ingredient  where date like '" + i + "%'";
                try
                {
                    dcc.ConnectWithDB();
                    SqlDataReader sdr = dcc.GetData(query);
                    while (sdr.Read())
                    {
                        ing = sdr[0].ToString();
                        expense = expense + Convert.ToDouble(ing);
                        tin = tin + Convert.ToDouble(ing);


                    }

                }
                catch (Exception exp)
                {

                }
                finally
                {
                    dcc.CloseConnection();
                }

                /////////////////////////////////////////////////

                query = "SELECT sum(Fprice) FROM Fixcost  where Fdate like '" + i + "%'";
                try
                {
                    dcc.ConnectWithDB();
                    SqlDataReader sdr = dcc.GetData(query);
                    while (sdr.Read())
                    {
                        fx = sdr[0].ToString();
                        expense = expense + Convert.ToDouble(fx);
                        tfx = tfx + Convert.ToDouble(fx);
                    }

                }
                catch (Exception exp)
                {

                }
                finally
                {
                    dcc.CloseConnection();
                }


                /////////////////////////////////////

                query = "SELECT sum(Salary) FROM Employees ";
                try
                {
                    dcc.ConnectWithDB();
                    SqlDataReader sdr = dcc.GetData(query);
                    while (sdr.Read())
                    {
                        if (!or.Equals(""))
                        {
                            em = sdr[0].ToString();
                            expense = expense + Convert.ToDouble(em);
                            tsal = tsal + Convert.ToDouble(em);
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

                /////////////////////////////////////
                chart1.Series["Ingredient"].Points.AddXY(i, ing);
                chart1.Series["Fixcost"].Points.AddXY(i, fx);
                chart1.Series["Salary"].Points.AddXY(i, em);
                chart1.Series["Income"].Points.AddXY(i, or);

                

            }
            Profit.Series["Income"].Points.AddXY("Total", income);
            Profit.Series["Expense"].Points.AddXY("Total", expense);

            Profit.Series["Income"].IsValueShownAsLabel = true;
            Profit.Series["Expense"].IsValueShownAsLabel = true;
            pie.Series["s1"].Points.AddXY("Sal", tsal);
            pie.Series["s1"].Points.AddXY("Fix cost", tfx);
            pie.Series["s1"].Points.AddXY("Ingredient", tin);
            pie.Series["s1"].IsValueShownAsLabel = true;

            Total.Enabled = false;

        }
    }
}
