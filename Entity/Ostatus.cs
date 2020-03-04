using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Ostatus
    {
        string oid;

        public string Oid
        {
            get { return oid; }
            set { oid = value; }
        }

        string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        
    }
}
