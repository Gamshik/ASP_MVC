using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbAccess.Configure
{
    public class SettlementConfiguration : IEntityTypeConfiguration<Settlement>
    {
        public void Configure(EntityTypeBuilder<Settlement> builder)
        {
            builder
                .HasKey(s => s.Id);

            builder
                .Property(s => s.Id)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("NEWSEQUENTIALID()");

            builder
                .Property(s => s.Title)
                .IsRequired();

            builder
                .HasMany(s => s.RouteStartSettlements)
                .WithOne(r => r.StartSettlement)
                .HasForeignKey(r => r.StartSettlementId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(s => s.RouteEndSettlements)
                .WithOne(r => r.EndSettlement)
                .HasForeignKey(r => r.EndSettlementId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
