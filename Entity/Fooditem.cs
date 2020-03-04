using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Fooditem
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

        double foodprice;

        public double Foodprice
        {
            get { return foodprice; }
            set { foodprice = value; }
        }
    }
}
