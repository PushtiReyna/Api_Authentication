using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Data_Layer.Entities;

public partial class UserApidbContext : DbContext
{
    public UserApidbContext()
    {
    }

    public UserApidbContext(DbContextOptions<UserApidbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CategoryMst> CategoryMsts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=ARCHE-ITD440\\SQLEXPRESS;Database=UserAPIDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CategoryMst>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Category__19093A0B810E2F3C");

            entity.ToTable("CategoryMst");

            entity.Property(e => e.Categoryname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
