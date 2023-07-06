using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFPractice.Models;

public partial class NewContext : DbContext
{
    public NewContext()
    {
    }

    public NewContext(DbContextOptions<NewContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<Table1> Table1s { get; set; }

    public virtual DbSet<Table2> Table2s { get; set; }

    public virtual DbSet<Table3> Table3s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=YBANALA-L-5498\\SQLEXPRESS;Initial Catalog=New;User ID=sa;Password=Welcome2evoke@1234; Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Report>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("report");

            entity.Property(e => e.Few)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("few");
            entity.Property(e => e.Most)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.New).HasColumnName("new");
            entity.Property(e => e.Some).HasColumnName("some");
        });

        modelBuilder.Entity<Table1>(entity =>
        {
            entity.HasKey(e => e.AvengerId);

            entity.ToTable("Table1");

            entity.Property(e => e.AvengerId).ValueGeneratedNever();
            entity.Property(e => e.AvengerName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Table2>(entity =>
        {
            entity.HasKey(e => e.AvengerSeries);

            entity.ToTable("Table2");

            entity.Property(e => e.AvengerSeries)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SeriesName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Avenger).WithMany(p => p.Table2s)
                .HasForeignKey(d => d.AvengerId)
                .HasConstraintName("FK_Table2_Table1");
        });

        modelBuilder.Entity<Table3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Table_3");

            entity.Property(e => e.New).HasColumnName("new");
            entity.Property(e => e.Some).HasColumnName("some");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
