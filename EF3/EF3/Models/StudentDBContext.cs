using EF3.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace EF3ex.Models
{
    public partial class StudentDBContext : DbContext
    {

        public StudentDBContext(DbContextOptions<StudentDBContext> options)
        : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=YBANALA-L-5498\\SQLEXPRESS;Initial Catalog=stddb;User ID=sa;Password=Welcome2evoke@1234; Trust Server Certificate=true");


        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}