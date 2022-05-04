using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StoreLoc.APIData
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string WhatsApp { get; set; }
        public string Email { get; set; }
        public double Rating { get; set; }
        public string StoreCategory { get; set; }
        public string OperationalHours { get; set; }

        [ForeignKey(nameof(Province))]
        public int ProvinceId { get; set; }
        public Province Province { get; set; }
    }
}
//must edit data tables store & malls need to change
