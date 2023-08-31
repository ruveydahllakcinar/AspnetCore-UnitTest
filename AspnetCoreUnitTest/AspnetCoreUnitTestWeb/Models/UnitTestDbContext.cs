using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AspnetCoreUnitTestWeb.Models;

public partial class UnitTestDbContext : DbContext
{
    public UnitTestDbContext()
    {
    }

    public UnitTestDbContext(DbContextOptions<UnitTestDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.Color).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
