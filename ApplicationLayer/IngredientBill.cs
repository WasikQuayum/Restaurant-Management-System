using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Repository;

namespace ApplicationLayer
{
    public partial class IngredientBill : Form
    {
        IngredientRepo irp = new IngredientRepo();
        List<Ingredient> lst = new List<Ingredient>();
        List<Ingredient> tlst = new List<Ingredient>();

        public IngredientBill()
        {
            InitializeComponent();
            load();
        }


        public void load()
        { 
            lst = irp.GetALLIngredient();
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i].Price==0)
                    tlst.Add(lst[i]);
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = tlst;
            this.table.DataSource = bs;
            table.Columns[0].ReadOnly = true;
            table.Columns[1].ReadOnly = true;
            table.Columns[2].ReadOnly = true;
            table.Columns[3].ReadOnly = false;
        }


        private void btn4_Click(object sender, EventArgs e)//back to account gui
        {
            Accounts acc = new Accounts();
            acc.Visible = true;
            this.Visible = false;
        }

       

        private void onformclose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bupdate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in table.Rows)
            {
                
                if (item.Cells[0].Value != null)
                {     
                        Ingredient i = new Ingredient();
                        i.InvId = item.Cells[0].Value.ToString();
                        i.InvName = item.Cells[1].Value.ToString();
                        i.Quantity = item.Cells[2].Value.ToString();
                        i.Price = Convert.ToDouble(item.Cells[3].Value.ToString());
                        irp.UpdateIngredient(i);
                        

                    }
                   
              }
          

            MessageBox.Show("price updated");
            tlst.Clear();
            lst.Clear();
            load();
        }

        private void ch(object sender, DataGridViewCellValidatingEventArgs e)
        
            {
                if (e.ColumnIndex == 3) 
                {
                    float i;

                    if (!float.TryParse(Convert.ToString(e.FormattedValue), out i) )
                    {
                        e.Cancel = true;
                        MessageBox.Show("please enter numeric");
                    }
                    else
                    {
                        
                    }
                }
            }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Loginpage lp = new Loginpage();
            lp.Visible = true;
            this.Visible = false;
        }

        
        
        
    }
}
