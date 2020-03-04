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
    public partial class CreateMenue : Form
    {
        Fooditem fi;
        FooditemRepo fr;
        public CreateMenue()
        {
            InitializeComponent();
            this.fi = fi; ;
            fr = new FooditemRepo();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ManagerHompage hp=new ManagerHompage();
            hp.Visible = true;
            this.Visible = false;
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

        private void loadbtn_Click(object sender, EventArgs e)
        {
            string foodid = foodidtxt.Text;

            Fooditem fi = fr.GetFooditem(foodid);
            if (fi == null)
            {
                MessageBox.Show("Invalid id");
                this.refreshbtn_Click(sender, e);
            }
            else
            {
                this.foodnametxt.Text = fi.Foodname;
                this.pricetxt.Text = fi.Foodprice+"";
                this.refreshbtn.Enabled = true;
               
                this.addbtn.Enabled = false;
                this.deletebtn.Enabled = true;
                this.foodidtxt.Enabled = false;
                
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            this.foodidtxt.Text = "";
            this.foodnametxt.Text = "";
            this.pricetxt.Text = "";
            this.refreshbtn.Enabled = false;
            this.addbtn.Enabled = true;
            this.deletebtn.Enabled = true;
            this.updatebtn.Enabled = true;
           

                this.foodidtxt.Enabled=true;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Fooditem fi = new Fooditem();

          
                fi.Foodid = this.foodidtxt.Text;
                fi.Foodname = this.foodnametxt.Text;
                double price = Convert.ToDouble(this.pricetxt.Text);
                fi.Foodprice = price;
                if (fr.InsertFooditem(fi))
                {
                    MessageBox.Show("Fooditem Added. Foodid:"+fi.Foodid+"& Foodname : " +fi.Foodname+"& Foodprice : " +fi.Foodprice);
                     
                }
                else
                {
                    MessageBox.Show("Can not added");
                }
               
              
            

           /*catch (Exception exp)
            {
                MessageBox.Show("Invalid data");
            }*/
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            Fooditem fi = new Fooditem();
            fi.Foodid = this.foodidtxt.Text;
            if (fr.DeleteFooditem(fi))
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Can not delete");
            }

        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<Fooditem> listOfFooditem = fr.GetAllFooditem();
                this.foodtable.DataSource = listOfFooditem;
            }
            catch (Exception exp)
            {
 
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            Fooditem fi = new Fooditem();
            fi.Foodid = this.foodidtxt.Text;
            fi.Foodname = this.foodnametxt.Text;
            double price = Convert.ToDouble(this.pricetxt.Text);
            fi.Foodprice = price;

            if (fr.UpdateFooditem(fi))
            {
                MessageBox.Show("Update Done");
                this.viewbtn_Click(sender, e);
                this.refreshbtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Update not done");
            }
        }

        private void foodtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.foodidtxt.Text = foodtable.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.foodnametxt.Text = foodtable.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.pricetxt.Text = foodtable.Rows[e.RowIndex].Cells[2].Value.ToString();

            this.refreshbtn.Enabled = true;
           
            this.addbtn.Enabled = false;
            this.deletebtn.Enabled = true;
            this.updatebtn.Enabled = true;

            this.foodidtxt.Enabled = false;
        }

        private void loadbtn_Click_1(object sender, EventArgs e)
        {
            string foodid = foodidtxt.Text;
            Fooditem fi = new Fooditem();
            if (fi == null)
            {
                MessageBox.Show("Invalid Id");
                this.refreshbtn_Click(sender, e);
            }
            else
            {
                this.foodnametxt.Text = fi.Foodname;
                this.pricetxt.Text = fi.Foodprice + "";
                this.refreshbtn.Enabled = true;
               
                this.addbtn.Enabled = false;
                this.updatebtn.Enabled = true;
                this.deletebtn.Enabled = true;

                this.foodidtxt.Enabled = false;
            }
        }

        private void searchbtn_TextChanged(object sender, EventArgs e)
        {
            List<Fooditem> listOfFooditem = fr.GetAllFooditem();
            string keyword = searchbtn.Text.ToLower();
            List<Fooditem>searchList=listOfFooditem.FindAll(x=>((x.Foodid.ToLower().Contains(keyword))||((x.Foodname.ToLower().Contains(keyword))||((x.Foodprice.ToString().Contains(keyword))))));

            foodtable.DataSource = searchList;
        }

        private void onformclose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}
