using System;
using System.Collections.Generic;

namespace ADO.Models
{
    public partial class Staff
    {
        public Staff()
        {
            InverseManager = new HashSet<Staff>();
            Orders = new HashSet<Order>();
        }

        public long StaffId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public int? Phone { get; set; }
        public string? Active { get; set; }
        public long StoreId { get; set; }
        public long ManagerId { get; set; }

        public virtual Staff Manager { get; set; } = null!;
        public virtual Store Store { get; set; } = null!;
        public virtual ICollection<Staff> InverseManager { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
