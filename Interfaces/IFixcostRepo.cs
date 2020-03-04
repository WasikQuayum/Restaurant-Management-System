using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Interfaces
{
    public interface IFixcostRepo
    {
        bool InsertFix(Fixcost i);
        bool Deletefix(string a);
        List<Fixcost> GetALLfx();
    }
}
