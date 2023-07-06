using System;
using System.Collections.Generic;

namespace ADO.netProject.Models
{
    public partial class Stock
    {
        public long? StoreId { get; set; }
        public long? ProductId { get; set; }
        public int? Quantity { get; set; }

        public virtual Product? Product { get; set; }
        public virtual Store? Store { get; set; }
    }
}
