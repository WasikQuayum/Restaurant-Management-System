using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Orderitem
    {
        string foodid;

        public string Foodid
        {
            get { return foodid; }
            set { foodid = value; }
        }

        string foodname;

        public string Foodname
        {
            get { return foodname; }
            set { foodname = value; }
        }

        int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        double totalprice;

        public double Totalprice
        {
            get { return totalprice; }
            set { totalprice = value; }
        }

        


    }
}
