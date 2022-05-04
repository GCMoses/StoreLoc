using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreLoc.APIData
{
    public class Province
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        public virtual IList<Store> Stores { get; set; }
        public virtual IList<ShoppingCenter> ShoppingCenters { get; set; }
    }
}
