using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using Interface;
using System.Data.SqlClient;

namespace Repository
{
    public class Fixcostrepo
    {
        DatabaseConnectionClass dcc = new DatabaseConnectionClass();
        public Fixcostrepo()
        {
            dcc = new DatabaseConnectionClass();
        }


        public bool InsertFix(Fixcost i)
        {
            string query = "INSERT into Fixcost VALUES('" + i.Fid + "','" + i.Fxtitle + "'," + i.Fprice + ",'" + DateTime.Now.ToString() + "')";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
            finally
            {
                dcc.CloseConnection();
            }

         }

        public bool Deletefix(string a)
        {
            string query = "DELETE from Fixcost WHERE Fid='" + a + "'";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);

                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
            finally
            {
                dcc.CloseConnection();
            }
        }


        public List<Fixcost> GetALLfx()
        {
            try
            {
                List<Fixcost> listOffx = new List<Fixcost>();
                string query = "SELECT * FROM Fixcost";
                dcc.ConnectWithDB();
                SqlDataReader sdr = dcc.GetData(query);
                while (sdr.Read())
                {
                    Fixcost i = new Fixcost();
                    i.Fid = sdr["Fid"].ToString();
                    i.Fdate = sdr["Fdate"].ToString();
                    i.Fxtitle = sdr["Fxtitle"].ToString();
                    i.Fprice = Convert.ToDouble(sdr["Fprice"]);
                    listOffx.Add(i);
                }
                return listOffx;
            }
            catch (Exception exp)
            {
                return null;
            }
            finally
            {
                dcc.CloseConnection();
            }
        }



    }
}
