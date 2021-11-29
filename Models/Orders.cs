using System;
using System.Collections.Generic;

namespace Sugarbakers.Models
{
    public partial class Orders
    {
        public Orders()
        {
            ItemsonOrder = new HashSet<ItemsonOrder>();
        }

        public int OrdersId { get; set; }
        public int CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? FreightCharge { get; set; }
        public decimal? TotalDue { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual ICollection<ItemsonOrder> ItemsonOrder { get; set; }
    }
}
