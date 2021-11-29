using System;
using System.Collections.Generic;

namespace Sugarbakers.Models
{
    public partial class Zip
    {
        public Zip()
        {
            Customers = new HashSet<Customers>();
        }

        public string Zipcode { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public virtual ICollection<Customers> Customers { get; set; }
    }
}
