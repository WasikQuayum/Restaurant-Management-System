using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApplicationLayer
{
    public partial class EmployeeManagement : Form
    {
        Login l;
        EmployeeRepo er;
        LoginRepo lr;
        public EmployeeManagement(Login l)
        {
            InitializeComponent();
            this.l = l;
            er = new EmployeeRepo();
            lr = new LoginRepo();
        }

        private void btn4_Click(object sender, EventArgs e)//back btn
        {
            ManagerHompage hp = new ManagerHompage();
            hp.Visible = true;
            this.Visible = false;
        }
        private void On_form_close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void EmpTableCellClicked(object sender, DataGridViewCellEventArgs e)
        {
            this.EmpIdTF.Text = EmpTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.EmpNameTF.Text = EmpTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.PhnNumberTF2.Text = (EmpTable.Rows[e.RowIndex].Cells[2].Value.ToString()).Substring(4);
            this.DesignationTF.Text = EmpTable.Rows[e.RowIndex].Cells[4].Value.ToString();
            SalaryTF.Text = EmpTable.Rows[e.RowIndex].Cells[5].Value.ToString();
            passwordTF.Text = EmpTable.Rows[e.RowIndex].Cells[3].Value.ToString();

            this.AddBtn.Enabled = false;
            this.UpdateBtn.Enabled = true;
            this.DeleteBtn.Enabled = true;

            this.EmpIdTF.Enabled = false;
            this.passwordTF.Enabled = false;


        }

        private void SearchTBValueChanged(object sender, EventArgs e)
        {
            List<Employee> listOfEmployee = er.GetAllEmployees();
            string keyword = SearchBox.Text.ToLower();
            List<Employee> searchedList = listOfEmployee.FindAll(x => ((x.EmpId.ToLower()).Contains(keyword)) || ((x.EmpName.ToLower()).Contains(keyword)) || ((x.PhnNumber.ToLower()).Contains(keyword)) || ((x.Designation.ToLower()).Contains(keyword)));

            EmpTable.DataSource = searchedList;

        }

      

        private void btn2_Click_1(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Id = this.EmpIdTF.Text;
            Employee emp = new Employee();
            emp.EmpId = this.EmpIdTF.Text;

            if (lr.DeleteUser(l))
            {
                if (er.DeleteEmployee(emp))
                {
                    MessageBox.Show("Deleted");
                    //this.RefreshBtn_Click(sender, e);
                    //this.ViewAllBtn_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Can Not Delete");
            }

            this.AddBtn.Enabled = true;
            this.UpdateBtn.Enabled = false;
            this.DeleteBtn.Enabled = false;

            this.EmpIdTF.Enabled = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmpId = this.EmpIdTF.Text;
            emp.EmpName = this.EmpNameTF.Text;
            int phn = Convert.ToInt32(this.PhnNumberTF2.Text);
            emp.PhnNumber = this.PhnNumberTF1.Text + this.EmpIdTF.Text;
            emp.Designation = this.DesignationTF.Text;
            emp.Salary = Convert.ToDouble(SalaryTF.Text);
            Login l=new Login();
            l.Id=this.EmpIdTF.Text;
            l.Password=this.passwordTF.Text;

            if (er.UpdateEmployee(emp))
            {
                if(lr.UpdateUser(l))
                {
                MessageBox.Show("Update Done");
                }
                //this.RefreshBtn_Click(sender, e);
                //this.ViewAllBtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Update NOT Done");
            }
            this.AddBtn.Enabled = true;
            this.UpdateBtn.Enabled = false;
            this.DeleteBtn.Enabled = false;

            this.EmpIdTF.Enabled = true;
        }

        private void ViewAllBtn_Click(object sender, EventArgs e)
        {
            List<Employee> listOfEmployee = er.GetAllEmployees();
            this.EmpTable.DataSource = listOfEmployee;
        }

        private void onformclose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmpId = this.EmpIdTF.Text;
            emp.EmpName = this.EmpNameTF.Text;
            int phn = Convert.ToInt32(this.PhnNumberTF2.Text);
            emp.PhnNumber = this.PhnNumberTF1.Text + this.EmpIdTF.Text;
            emp.Designation = this.DesignationTF.Text;
            emp.Salary = Convert.ToDouble(SalaryTF.Text);
            Login l = new Login();
            l.Id = this.EmpIdTF.Text;
            l.Password = this.passwordTF.Text;

            if (er.InsertEmployee(emp))
            {
                if (lr.InsertUser(l))
                {
                    MessageBox.Show("Insert Done");
                }
                //this.RefreshBtn_Click(sender, e);
                //this.ViewAllBtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Insert NOT Done");
            }
        }
        private void logoutbtn_Click(object sender, System.EventArgs e)
        {
            Loginpage lp = new Loginpage();
            this.Visible = false;
            lp.Visible = true;
        }

       
    }
}
