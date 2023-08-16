using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DoctorAppointmentPortal2.Models;

public partial class DoctorDatabaseContext : DbContext
{
    public DoctorDatabaseContext()
    {
    }

    public DoctorDatabaseContext(DbContextOptions<DoctorDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<Disease> Diseases { get; set; }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<User> Users { get; set; }

    




    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=YBANALA-L-5498\\SQLEXPRESS;Initial Catalog=DoctorDatabase;Persist Security Info=True;User ID=sa;Password=Welcome2evoke@1234; Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => e.AppointmentId).HasName("PK__Appointm__8ECDFCA293C4AD32");

            entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");
            entity.Property(e => e.AppointmentStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('Scheduled')");
            entity.Property(e => e.AppointmentTime).HasColumnType("datetime");
            entity.Property(e => e.DoctorAvailableTime).HasMaxLength(150);
            entity.Property(e => e.DoctorToVisit)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MedicalIssue)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Notes).HasColumnType("text");
            entity.Property(e => e.PatientName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('Pending')");

            entity.HasOne(d => d.MedicalIssueNavigation).WithMany(p => p.Appointments)
                .HasPrincipalKey(p => p.DiseaseName)
                .HasForeignKey(d => d.MedicalIssue)
                .HasConstraintName("FK__Appointme__Medic__52593CB8");
        });

        modelBuilder.Entity<Disease>(entity =>
        {
            entity.HasKey(e => e.DiseaseId).HasName("PK__Diseases__69B533A90A0B5120");

            entity.HasIndex(e => e.DiseaseName, "uc_DiseaseName").IsUnique();

            entity.Property(e => e.DiseaseId).HasColumnName("DiseaseID");
            entity.Property(e => e.DiseaseName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.SuitableDoctorNavigation).WithMany(p => p.Diseases)
                .HasForeignKey(d => d.SuitableDoctor)
                .HasConstraintName("FK_Diseases_Doctors");
        });

        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.HasKey(e => e.DoctorId).HasName("PK__Doctors__2DC00EDF91CECAE1");

            entity.HasIndex(e => e.Name, "uc_DoctorName").IsUnique();

            entity.Property(e => e.DoctorId).HasColumnName("DoctorID");
            entity.Property(e => e.AvailableDays)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClinicAddress)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Qualification)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Specialised)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
