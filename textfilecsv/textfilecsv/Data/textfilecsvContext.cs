using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using textfilecsv.Models;

namespace textfilecsv.Data
{
    public class textfilecsvContext : DbContext
    {
        public textfilecsvContext (DbContextOptions<textfilecsvContext> options)
            : base(options)
        {
        }

        public DbSet<textfilecsv.Models.student> student { get; set; } = default!;
    }
}
