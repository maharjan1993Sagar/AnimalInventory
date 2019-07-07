using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalInventory.Core.Data
{
    public class customer
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string dob { get; set; }
        public string mobile { get; set; }
        public string phone { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public string createdBy { get; set; }
    }
}
