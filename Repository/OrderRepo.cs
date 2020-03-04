using Entity;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Repository
{
    public class OrderRepo: IOrderRepo
    {
        DatabaseConnectionClass dcc;
        public OrderRepo()
        {
            dcc = new DatabaseConnectionClass();
        }

        public string Insertorder(List<Orderitem> listoforderitem)
        {
            dcc.ConnectWithDB();
            Random rd = new Random();
            string r = rd.Next(900, 1000) + "";

            try
            {
                for (int i = 0; i < listoforderitem.Count; i++)
                {
                    string query = "Insert into TOrderitem values ('" + r + "', '" + listoforderitem[i].Foodid + "', '" + listoforderitem[i].Foodname + "', " + listoforderitem[i].Quantity + "," + listoforderitem[i].Totalprice + ",'" + "waiting' , '"+ DateTime.Now.ToString() +"' )";
                    dcc.ExecuteSQL(query);
                    
                }
                return r;
            }
            catch (Exception exp)
            {
                return r;
            }
            finally
            {
                dcc.CloseConnection();
            }
        }


        public List<Ostatus> reostatus()
        {
            List<Ostatus> lsm = new List<Ostatus>();
            string query = "SELECT * FROM TOrderitem ";
            try
            {
                List<string> ss = new List<string>();
                dcc.ConnectWithDB();
                SqlDataReader sdr = dcc.GetData(query);
                
                while (sdr.Read())
                {
                    string a;
                    Ostatus os = new Ostatus();
                    a=os.Oid = sdr["TOrderid"].ToString();
                    os.Status = sdr["TStatus"].ToString();

                   /* if (!(ss.Contains(a)))
                    {
                        ss.Add(a);
                        lsm.Add(os);
                    }*/

                    if ( lsm.Find(x => (x.Oid).Equals(os.Oid)) == null  )
                    {
                        lsm.Add(os);
                    }
                }
                return lsm;

            }
            catch (Exception exp)
            {
                return lsm;
            }
            finally
            {
                dcc.CloseConnection();
            }

        }


        public List<string> Getidlist()
        {
            List<string> ac = new List<string>();
            string query = "SELECT * from TOrderitem";
            try
            {
                dcc.ConnectWithDB();
                SqlDataReader sdr = dcc.GetData(query);
                while (sdr.Read())
                {
                    string a;
                    a = sdr["TOrderid"].ToString();

                    if (!ac.Contains(a) && ((sdr["TStatus"].ToString()).Equals("waiting")))
                        ac.Add(a);
                }
                return ac;

            }
            catch (Exception exp)
            {
                return ac;
            }
            finally
            {
                dcc.CloseConnection();
            }
        }

        public List<Orderitem> Getall(string selected)
        {
            List<Orderitem> listoforderitem = new List<Orderitem>();
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
                return listoforderitem;

            }
            catch (Exception exp)
            {
                return listoforderitem;
            }
            finally
            {
                dcc.CloseConnection();
            }
        }

        public void setstatus(String selected,string status)
        {
            string query = "Update TOrderitem set TStatus = '"+status+"' where TOrderid ='" + selected + "'";
            try
            {
                dcc.ConnectWithDB();
                dcc.ExecuteSQL(query);
            }
            catch (Exception exp)
            {
            }
            finally
            {
                dcc.CloseConnection();
            }


        }




    }
}
