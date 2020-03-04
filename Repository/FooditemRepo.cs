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
    public class FooditemRepo:IFooditemRepo
    {
        DatabaseConnectionClass dcc;
        public FooditemRepo()
        {
            dcc = new DatabaseConnectionClass();
        }
        public bool InsertFooditem(Fooditem fi)
        {
            string query = "INSERT into Fooditem VALUES('" + fi.Foodid + "','" + fi.Foodname + "'," + fi.Foodprice + ")";
            {
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
        }
        public bool DeleteFooditem(Fooditem fi)
        {
            string query = "DELETE from Fooditem WHERE Foodid='" + fi.Foodid + "'";
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
        public bool UpdateFooditem(Fooditem fi)
        {
            string query = "UPDATE Fooditem SET Foodname= '" + fi.Foodname + "', Foodprice = " + fi.Foodprice + " WHERE Foodid = '" + fi.Foodid + "'";

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
        public Fooditem GetFooditem(string foodid)
        {
            Fooditem fi = null;
            string query = "SELECT *from Fooditem WHERE foodid ='" + foodid + "'";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                fi = new Fooditem();
                fi.Foodid = sdr["Foodid"].ToString();
                fi.Foodname = sdr["Foodname"].ToString();
                fi.Foodprice = Convert.ToDouble(sdr["Foodprice"]);
            }
            dcc.CloseConnection();
            return fi;
        }
        public List<Fooditem> GetAllFooditem()
        {
            List<Fooditem> listOfFooditem = new List<Fooditem>();
            string query = "SELECT* FROM Fooditem";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Fooditem fi = new Fooditem();
              
                fi.Foodid = sdr["Foodid"].ToString();
                fi.Foodname = sdr["Foodname"].ToString();
                fi.Foodprice = Convert.ToDouble(sdr["Foodprice"]);
                listOfFooditem.Add(fi);
            }
            dcc.CloseConnection();
            return listOfFooditem;
        }
    }
}
