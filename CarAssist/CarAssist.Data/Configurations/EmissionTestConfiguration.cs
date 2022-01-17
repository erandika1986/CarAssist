using CarAssist.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssist.Data.Configurations
{
    public class EmissionTestConfiguration : IEntityTypeConfiguration<EmissionTest>
    {
        public void Configure(EntityTypeBuilder<EmissionTest> builder)
        {
            builder.ToTable("EmissionTest");

            builder.HasKey(x => x.Id);
        }
    }
}
