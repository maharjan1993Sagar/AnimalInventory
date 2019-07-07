using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalInventory.Core.Data
{
    public class product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortDescription { get; set; }
        public string longDescription { get; set; }
        public decimal perUnitPrice { get; set; }
        public string unitOfMeasurement { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public string createdBy { get; set; }
    }
}
