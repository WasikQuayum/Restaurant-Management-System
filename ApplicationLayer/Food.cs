using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entity;
using Repository;

namespace ApplicationLayer
{
    public partial class Food : Form
    {
        Fooditem fi;
        FooditemRepo fr;
        public Food()
        {
            InitializeComponent();
            this.fi = fi;
            fr = new FooditemRepo();
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

        private void searchbtn_TextChanged(object sender, EventArgs e)
        {
            List<Fooditem> listOfFooditem = fr.GetAllFooditem();
            string keyword = searchbtn.Text.ToLower();
            List<Fooditem> searchList = listOfFooditem.FindAll(x => ((x.Foodid.ToLower().Contains(keyword)) || ((x.Foodname.ToLower().Contains(keyword)) || ((x.Foodprice.ToString().Contains(keyword))))));

            foodtable.DataSource = searchList;
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

        private void onformclose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void back_Click(object sender, EventArgs e)
        {
            ManagerHompage hp = new ManagerHompage();
            hp.Visible = true;
            this.Visible = false;
        }
    }
}
