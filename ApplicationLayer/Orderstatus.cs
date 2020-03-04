using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationLayer
{
    public partial class Orderstatus : Form
    {
        
        List<Ostatus> lsm = new List<Ostatus>();
        public Orderstatus()
        {
            
            InitializeComponent();
            vload();
            
        }

        void vload()
        {
            lsm.Clear();
            OrderRepo o = new OrderRepo();
            lsm = o.reostatus();

            
            //MessageBox.Show(lsm[0].Oid);
            torderstatus.DataSource = lsm;

        }





        private void onformclose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Accounts ac = new Accounts();
            ac.Visible = true;
            this.Visible = false;
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            string keyword = search.Text.ToLower();
            List<Ostatus> searchedList = lsm.FindAll(x => ((x.Oid.ToLower()).Contains(keyword)) || ((x.Status.ToLower()).Contains(keyword)));
            torderstatus.DataSource = searchedList;
            
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Loginpage lp = new Loginpage();
            lp.Visible = true;
            this.Visible = false;
        }

       
    }
}
