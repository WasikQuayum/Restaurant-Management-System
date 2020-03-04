using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using Interface;
using System.Data.SqlClient;

namespace Repository
{
    public class IngredientRepo:IIngredientRepo
    {
        DatabaseConnectionClass dcc = new DatabaseConnectionClass();
        public IngredientRepo()
        {
            dcc = new DatabaseConnectionClass();
        }

        public bool InsertIngredient(Ingredient i)
        {
            string query = "INSERT into Ingredient VALUES('" + i.InvId + "','" + i.InvName + "','" + i.Quantity + "'," + i.Price + ",'"+DateTime.Now.ToString()+"')";
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
        public bool DeleteIngredient(Ingredient i)
        {
            string query = "DELETE from Ingredient WHERE InvId='" + i.InvId + "'";
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
        public bool UpdateIngredient(Ingredient i)
        {
            string query = "UPDATE Ingredient SET InvName='" + i.InvName + "',InvQuantity='" + i.Quantity + "',InvPrice=" + i.Price + "WHERE InvId='" + i.InvId + "'";
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
        public Ingredient GetIngredient(string invId)
        {
            try
            {
                Ingredient i = null;
                string query = "SELECT * from Ingredient WHERE invID='" + invId + "'";
                dcc.ConnectWithDB();
                SqlDataReader sdr = dcc.GetData(query);

                while (sdr.Read())
                {
                    i = new Ingredient();
                    i.InvId = sdr["InvId"].ToString();
                    i.InvName = sdr["InvName"].ToString();
                    i.Quantity = sdr["InvQuantity"].ToString();
                    i.Price = Convert.ToDouble(sdr["InvPrice"]);
                }
                return i;
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
        public List<Ingredient> GetALLIngredient()
        {
            try
            {
                List<Ingredient> listOfIngredient = new List<Ingredient>();
                string query = "SELECT * FROM Ingredient";
                dcc.ConnectWithDB();
                SqlDataReader sdr = dcc.GetData(query);
                while (sdr.Read())
                {
                    Ingredient i = new Ingredient();
                    i.InvId = sdr["InvId"].ToString();
                    i.InvName = sdr["InvName"].ToString();
                    i.Quantity = sdr["InvQuantity"].ToString();
                    i.Price = Convert.ToDouble(sdr["InvPrice"]);
                    listOfIngredient.Add(i);
                }
                return listOfIngredient;
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
