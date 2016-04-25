using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgilityLog.DataAccess.Entities;
using Microsoft.Data.Entity;

namespace AgilityLog.DataAccess.EntityRepository.Configurations
{
    public class AgilityClassConfiguration : EntityConfiguration<AgilityClass>
    {
        public override void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AgilityClass>()
                .HasOne(c => c.RelatedShow)
                .WithMany(s => s.Classes)
                .HasForeignKey(c => c.ShowId);

            modelBuilder.Entity<AgilityClass>()
                .Property(c => c.JudgesName)
                .IsRequired();

            modelBuilder.Entity<AgilityClass>()
                .Property(c => c.Name)
                .IsRequired();
        }
    }
}
