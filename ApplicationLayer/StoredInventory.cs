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
    public partial class StoredInventory : Form
    {
        Ingredient i;
        IngredientRepo ir;
        public StoredInventory()
        {
            InitializeComponent();
            this.i = i;
            ir = new IngredientRepo();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ManagerHompage hp = new ManagerHompage();
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

        private void viewbtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<Ingredient> listOfIngredient = ir.GetALLIngredient();
                this.inventorytable.DataSource = listOfIngredient;
            }
            catch (Exception exp)
            { }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            List<Ingredient> listOfIngredient = ir.GetALLIngredient();
            string key = search.Text.ToLower();
            List<Ingredient> searchList = listOfIngredient.FindAll(x => ((x.InvId.ToLower()).Contains(key)) || ((x.InvName.ToLower()).Contains(key)) || ((x.Quantity.ToString().ToLower()).Contains(key)) || ((x.Price.ToString().ToLower()).Contains(key)));
            inventorytable.DataSource = searchList;
        }

        private void onformclose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void totalbtn_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < inventorytable.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(inventorytable.Rows[i].Cells[3].Value);
            }
            totalsum.Text += sum.ToString();
        }
    }
}
