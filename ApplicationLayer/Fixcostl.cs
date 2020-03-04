using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationLayer
{
    public partial class Fixcostl : Form
    {

        List<Fixcost> fx = new List<Fixcost>();
        public Fixcostl()
        {
            InitializeComponent();
            Load();
        }

        public void Load()
        {
            fx.Clear();
            Fixcostrepo fr=new Fixcostrepo();
            fx = fr.GetALLfx();
            
            

            BindingSource bs = new BindingSource();
            bs.DataSource = fx;
            this.tbl.DataSource = bs;
            idtb.Text = "";
            pricetb.Text = "";
            titletb.Text = "";
           
        }

        private void onformclose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void badd_Click(object sender, EventArgs e)
        {
            Fixcostrepo fr = new Fixcostrepo();
            Fixcost i = new Fixcost();
            Random rd = new Random();
            i.Fid = rd.Next(999, 1333).ToString();
            i.Fxtitle = titletb.Text;
            i.Fprice = Convert.ToDouble(pricetb.Text);
            

            fr.InsertFix(i);
            
            Load();

        }

        private void del_Click(object sender, EventArgs e)
        {
            Fixcostrepo fr = new Fixcostrepo();
            fr.Deletefix(idtb.Text);
            badd.Enabled = true;
            del.Enabled = false;

            Load();

        }

        private void back_Click(object sender, EventArgs e)
        {
            ManagerHompage hp = new ManagerHompage();
            hp.Visible = true;
            this.Visible = false;
        }

        private void logout(object sender, EventArgs e)
        {
            Loginpage lp = new Loginpage();
            lp.Visible = true;
            this.Visible = false;
        }

        private void tblclick(object sender, DataGridViewCellEventArgs e)
        {
            idtb.Text = tbl.Rows[e.RowIndex].Cells[0].Value.ToString();
            

            badd.Enabled = false;
            del.Enabled = true;
            
            
        }

        

        private void ch(object sender, EventArgs e)
        {
            float i;
            if (!pricetb.Text.Equals(""))
            {
                if (!float.TryParse(pricetb.Text, out i))
                {

                    MessageBox.Show("please enter numeric");
                    pricetb.Text = "";
                }
            }
            
        }

       
    }
}
