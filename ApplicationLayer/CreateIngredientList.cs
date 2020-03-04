using Entity;
using Repository;
using Interfaces;
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
    public partial class CreateIngredientList : Form
    {
        List<Ingredient> ingre = new List<Ingredient>();

        public CreateIngredientList()
        {
            InitializeComponent();
            qtype.SelectedIndex = 0;
            qtype.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Chef cf = new Chef();
            cf.Visible = true;
            this.Visible = false;
        }      
        private void onformclose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            string id = rd.Next(1000, 5000).ToString();
            if (!String.IsNullOrEmpty(tname.Text) && !String.IsNullOrEmpty(tq.Text))
            {
                Ingredient i = new Ingredient();
                i.InvId = id;
                i.InvName = tname.Text;
                i.Quantity = tq.Text + qtype.SelectedItem.ToString();
                ingre.Add(i);
            }
            else
                MessageBox.Show("Fill all field first");
            tname.Text = tq.Text = null;

            BindingSource bs = new BindingSource();
            bs.DataSource = ingre;
            this.tbl.DataSource = bs;     
        }

        private void tbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           idtb.Text= tbl.Rows[e.RowIndex].Cells[0].Value.ToString();
           tname.Text = tbl.Rows[e.RowIndex].Cells[1].Value.ToString();

           badd.Enabled = false;
           del.Enabled = true;
           iupdate.Enabled = true;


        }

        private void cc(object sender, DataGridViewCellEventArgs e)
        {
            tbl_CellContentClick(sender, e);
        }

        private void del_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ingre.Count; i++)
            {
                if(ingre[i].InvId.Equals(idtb.Text))
                {
                    ingre.Remove(ingre[i]);
                    break;
                }
            }
            idtb.Text = tname.Text = tq.Text = null;
            badd.Enabled = true;
            del.Enabled = false;
            iupdate.Enabled = false;
            BindingSource bs = new BindingSource();
            bs.DataSource = ingre;
            this.tbl.DataSource = bs; 
        }

        private void iupdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ingre.Count; i++)
            {
                if (ingre[i].InvId.Equals(idtb.Text))
                {
                    ingre[i].InvName = tname.Text;
                    ingre[i].Quantity = tq.Text + qtype.SelectedItem.ToString();
                    break;
                }
            }
            idtb.Text = tname.Text = tq.Text = null;
            badd.Enabled = true;
            del.Enabled = false;
            iupdate.Enabled = false;
            BindingSource bs = new BindingSource();
            bs.DataSource = ingre;
            this.tbl.DataSource = bs; 

        }

        private void bupdate_Click(object sender, EventArgs e)
        {
            IngredientRepo irp = new IngredientRepo();
            bool flag = false;

            for (int i = 0; i < ingre.Count; i++)
            {
                flag = irp.InsertIngredient(ingre[i]);
            }
            if (flag)
            {
                MessageBox.Show("value inserted");
                ingre.Clear();
                BindingSource bs = new BindingSource();
                bs.DataSource = ingre;
                this.tbl.DataSource = bs;
            }
            else
            {
                MessageBox.Show("value not inserted");
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
