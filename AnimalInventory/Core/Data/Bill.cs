using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalInventory.Core.Data
{
    public class Bill
    {
        public int id { get; set; }
        public string billNo { get; set; }
        public string date { get; set; }
        public string quantity { get; set; }
        public string subTotal { get; set; }
        public int? customerId { get; set; }
        public virtual customer customer { get; set; }
        public int? productId { get; set; }
        public virtual product product { get; set; }


    }
}
