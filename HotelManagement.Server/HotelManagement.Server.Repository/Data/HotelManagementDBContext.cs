using System;
using System.Collections.Generic;
using HotelManagement.Server.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Server.Repository.Data;

public partial class HotelManagementDBContext : DbContext
{
    public HotelManagementDBContext()
    {
    }

    public HotelManagementDBContext(DbContextOptions<HotelManagementDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Hotel> Hotels { get; set; }

    public virtual DbSet<Signup> Signups { get; set; }

    public virtual DbSet<SignupStatus> SignupStatuses { get; set; }

    public virtual DbSet<SubscriptionTenure> SubscriptionTenures { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=C:\\Users\\KK016874\\OneDrive - Zelis Healthcare\\Documents\\Projects\\HotelManagement\\HotelManagement.Server\\HotelManagement.Server.Repository\\SQlite File\\HotelManagementDB.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Hotel>(entity =>
        {
            entity.ToTable("HOTELS");

            entity.Property(e => e.HotelId)
                .ValueGeneratedNever()
                .HasColumnType("INT")
                .HasColumnName("HOTEL_ID");
            entity.Property(e => e.HotelAddress)
                .HasColumnType("NVARCHAR(1000)")
                .HasColumnName("HOTEL_ADDRESS");
            entity.Property(e => e.HotelName)
                .HasColumnType("NVARCHAR(100)")
                .HasColumnName("HOTEL_NAME");
        });

        modelBuilder.Entity<Signup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SIGNUP");

            entity.Property(e => e.Email)
                .HasColumnType("NVARCHAR(50)")
                .HasColumnName("EMAIL");
            entity.Property(e => e.HotelId)
                .HasColumnType("INT")
                .HasColumnName("HOTEL_ID");
            entity.Property(e => e.Mobile)
                .HasColumnType("NVARCHAR(50)")
                .HasColumnName("MOBILE");
            entity.Property(e => e.Name)
                .HasColumnType("NVARCHAR(50)")
                .HasColumnName("NAME");
            entity.Property(e => e.Password)
                .HasColumnType("NVARCHAR(1000)")
                .HasColumnName("PASSWORD");
            entity.Property(e => e.SignupStatusId)
                .HasColumnType("INT")
                .HasColumnName("SIGNUP_STATUS_ID");
            entity.Property(e => e.SubscriptionTenureId)
                .HasColumnType("INT")
                .HasColumnName("SUBSCRIPTION_TENURE_ID");

            entity.HasOne(d => d.Hotel).WithMany().HasForeignKey(d => d.HotelId);

            entity.HasOne(d => d.SignupStatus).WithMany().HasForeignKey(d => d.SignupStatusId);

            entity.HasOne(d => d.SubscriptionTenure).WithMany().HasForeignKey(d => d.SubscriptionTenureId);
        });

        modelBuilder.Entity<SignupStatus>(entity =>
        {
            entity.ToTable("SIGNUP_STATUS");

            entity.Property(e => e.SignupStatusId)
                .ValueGeneratedNever()
                .HasColumnType("INT")
                .HasColumnName("SIGNUP_STATUS_ID");
            entity.Property(e => e.SignupStatusDescription)
                .HasColumnType("NVARCHAR(100)")
                .HasColumnName("SIGNUP_STATUS_DESCRIPTION");
        });

        modelBuilder.Entity<SubscriptionTenure>(entity =>
        {
            entity.ToTable("SUBSCRIPTION_TENURE");

            entity.Property(e => e.SubscriptionTenureId)
                .ValueGeneratedNever()
                .HasColumnType("INT")
                .HasColumnName("SUBSCRIPTION_TENURE_ID");
            entity.Property(e => e.SubscriptionTenureDescription)
                .HasColumnType("NVARCHAR(100)")
                .HasColumnName("SUBSCRIPTION_TENURE_DESCRIPTION");
            entity.Property(e => e.SubscriptionTenurePeriod)
                .HasColumnType("INT")
                .HasColumnName("SUBSCRIPTION_TENURE_PERIOD");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
