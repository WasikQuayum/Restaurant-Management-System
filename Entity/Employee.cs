using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Employee
    {
         string empId;

        public string EmpId
        {
            get { return empId; }
            set { empId = value; }
        }

        string empName;

        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }

        private string phnNumber;

        public string PhnNumber
        {
            get { return phnNumber; }
            set { phnNumber = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string designation;

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }
        double salary;

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
