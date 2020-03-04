using Entity;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        DatabaseConnectionClass dcc;

        public EmployeeRepo()
        {
            dcc = new DatabaseConnectionClass();
        }

        public bool InsertEmployee(Employee emp)
        {
            string query = "INSERT into Employees VALUES('" + emp.EmpId + "', '" + emp.EmpName + "', '" + emp.PhnNumber + "', '" + emp.Designation + "',"+emp.Salary+")";
            try
            {
                dcc.ConnectWithDB();
                dcc.ExecuteSQL(query);
                
                return true;
            }
            catch (Exception exp) { return false; }
            finally
            {
                dcc.CloseConnection();
            }
        }

        public bool DeleteEmployee(Employee emp)
        {
            string query = "DELETE from Employees WHERE EmpId = '" + emp.EmpId + "'";
            try
            {
                dcc.ConnectWithDB();
                dcc.ExecuteSQL(query);
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

        public bool UpdateEmployee(Employee emp)
        {
            string query = "UPDATE Employees SET  EmpName = '" + emp.EmpName + "', PhnNumber = '" + emp.PhnNumber + "', Designation = '" + emp.Designation + "' , Salary = "+emp.Salary + " WHERE EmpId = '" + emp.EmpId + "'";
            try
            {
                dcc.ConnectWithDB();
                dcc.ExecuteSQL(query);
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

        public Employee GetEmployee(string empId)
        {
            Employee emp = null;
            string query = "SELECT * from Employees WHERE empId = '" + empId + "'";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                emp = new Employee();
                emp.EmpId = sdr["EmpId"].ToString();
                emp.EmpName = sdr["EmpName"].ToString();
                emp.PhnNumber = sdr["PhnNumber"].ToString();
                emp.Designation = sdr["Designation"].ToString();
                emp.Salary = Convert.ToDouble(sdr["Salary"].ToString());
            }
            dcc.CloseConnection();
            return emp;
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> listOfEmployee = new List<Employee>();
            string query = "SELECT * FROM Employees";
            string query2 = "Select * from Login";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            ;
            while (sdr.Read())
            {
                Employee emp = new Employee();
                emp.EmpId = sdr["EmpId"].ToString();
                emp.EmpName = sdr["EmpName"].ToString();
                emp.PhnNumber = sdr["PhnNumber"].ToString();
                emp.Designation = sdr["Designation"].ToString();
                emp.Salary = Convert.ToDouble(sdr["Salary"].ToString());
                Login l = new Login();
                LoginRepo lr = new LoginRepo();
                l = lr.Getpass(emp.EmpId);
                emp.Password = l.Password;
                listOfEmployee.Add(emp);
            }
            dcc.CloseConnection();

            return listOfEmployee;
        }
    }
}
