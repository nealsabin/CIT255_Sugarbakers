using System;
using System.Collections.Generic;

namespace Sugarbakers.Models
{
    public partial class Products
    {
        public Products()
        {
            ItemsonOrder = new HashSet<ItemsonOrder>();
        }

        public int ProductsId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ItemsonOrder> ItemsonOrder { get; set; }
    }
}
