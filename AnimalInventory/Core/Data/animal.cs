using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalInventory.Core.Data
{
    public class animal
    {
        public int id { get; set; }
        public string animalName { get; set; }
        public string type { get; set; }
        public string weight { get; set; }
        public int? vendorId { get; set; }
        public virtual vendor vendor { get; set; }
    }

}
