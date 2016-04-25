using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgilityLog.DataAccess.Entities;
using Microsoft.Data.Entity;

namespace AgilityLog.DataAccess.EntityRepository.Configurations
{
    public class AgilityShowConfiguration : EntityConfiguration<AgilityShow>
    {
        public override void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AgilityShow>()
                .Property(s => s.Name)
                .IsRequired();
        }
    }
}
