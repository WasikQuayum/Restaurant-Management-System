using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IFooditemRepo
    {
        bool InsertFooditem(Fooditem fi);
        bool DeleteFooditem(Fooditem fi);
        bool UpdateFooditem(Fooditem fi);
        Fooditem GetFooditem(string foodid);
        List<Fooditem> GetAllFooditem();
    }
}
