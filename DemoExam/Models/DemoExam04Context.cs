using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DemoExam.Models;

public partial class DemoExam04Context : DbContext
{
    public DemoExam04Context()
    {
    }

    public DemoExam04Context(DbContextOptions<DemoExam04Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<HomeTech> HomeTeches { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<Problem> Problems { get; set; }

    public virtual DbSet<Request> Requests { get; set; }

    public virtual DbSet<RequestStatus> RequestStatuses { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=DemoExam04;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Account__3214EC07E75E25A9");

            entity.ToTable("Account");

            entity.Property(e => e.FullName).HasMaxLength(100);
            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.Type)
                .HasConstraintName("FK__Account__Type__38996AB5");
        });

        modelBuilder.Entity<HomeTech>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HomeTech__3214EC072A5F98D1");

            entity.ToTable("HomeTech");

            entity.Property(e => e.Model).HasMaxLength(100);
            entity.Property(e => e.RepairParts).HasMaxLength(100);
            entity.Property(e => e.Type).HasMaxLength(20);
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Message__3214EC07B73A8841");

            entity.ToTable("Message");

            entity.Property(e => e.Message1)
                .HasMaxLength(100)
                .HasColumnName("Message");

            entity.HasOne(d => d.MasterNavigation).WithMany(p => p.Messages)
                .HasForeignKey(d => d.Master)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Message__Master__47DBAE45");

            entity.HasOne(d => d.RequestNavigation).WithMany(p => p.Messages)
                .HasForeignKey(d => d.Request)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Message__Request__48CFD27E");
        });

        modelBuilder.Entity<Problem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Problem__3214EC078F5A79DC");

            entity.ToTable("Problem");

            entity.Property(e => e.Description).HasMaxLength(500);
        });

        modelBuilder.Entity<Request>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Request__3214EC07B092C255");

            entity.ToTable("Request");

            entity.HasOne(d => d.ClientNavigation).WithMany(p => p.RequestClientNavigations)
                .HasForeignKey(d => d.Client)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Request__Client__4316F928");

            entity.HasOne(d => d.MasterNavigation).WithMany(p => p.RequestMasterNavigations)
                .HasForeignKey(d => d.Master)
                .HasConstraintName("FK__Request__Master__4222D4EF");

            entity.HasOne(d => d.ObjectNavigation).WithMany(p => p.Requests)
                .HasForeignKey(d => d.Object)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Request__Object__412EB0B6");

            entity.HasOne(d => d.ProblemNavigation).WithMany(p => p.Requests)
                .HasForeignKey(d => d.Problem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Request__Problem__44FF419A");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.Requests)
                .HasForeignKey(d => d.Status)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Request__Status__440B1D61");
        });

        modelBuilder.Entity<RequestStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RequestS__3214EC07F5FFB5E0");

            entity.ToTable("RequestStatus");

            entity.Property(e => e.Status).HasMaxLength(30);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Role__3214EC07CCA07ED2");

            entity.ToTable("Role");

            entity.Property(e => e.Type).HasMaxLength(30);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
