using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OSICI.Database;

public partial class OSICI_Context : DbContext
{
    public OSICI_Context(DbContextOptions<OSICI_Context> options)
        : base(options)
    {
    }

    public virtual DbSet<ServerMachineData> ServerMachineDatas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ServerMachineData>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Server_M__3214EC278F957A70");

            entity.ToTable("Server_Machine_Datas");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
