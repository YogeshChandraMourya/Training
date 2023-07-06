using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EvokeWebApi.Models;

public partial class PlayersContext : DbContext
{
    public PlayersContext()
    {
    }

    public PlayersContext(DbContextOptions<PlayersContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PlayersTbl> PlayersTbls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=YBANALA-L-5498\\SQLEXPRESS;Initial Catalog=Players;User ID=sa;Password=Welcome2evoke@1234; Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PlayersTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Players");

            entity.ToTable("PlayersTbl");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Achievement)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("achievement");
            entity.Property(e => e.Countryorigin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("countryorigin");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Skilled)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("skilled");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
