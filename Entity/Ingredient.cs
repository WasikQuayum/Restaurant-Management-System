using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Ingredient
    {
        string invId;

        public string InvId
        {
            get { return invId; }
            set { invId = value; }
        }
        string invName;

        public string InvName
        {
            get { return invName; }
            set { invName = value; }
        }
        string quantity;

        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
