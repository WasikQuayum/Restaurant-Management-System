using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IOrderRepo
    {
        string Insertorder(List<Orderitem> listoforderitem);
        List<Ostatus> reostatus();
    }
}
