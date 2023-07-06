using System;
using System.Collections.Generic;

namespace ADO.netProject.Models
{
    public partial class Product
    {
        public long ProductId { get; set; }
        public string? ProductName { get; set; }
        public long? BrandId { get; set; }
        public long? CategoryId { get; set; }
        public int? ModelYear { get; set; }
        public decimal? ListPrice { get; set; }

        public virtual Brand? Brand { get; set; }
        public virtual Category? Category { get; set; }
    }
}
