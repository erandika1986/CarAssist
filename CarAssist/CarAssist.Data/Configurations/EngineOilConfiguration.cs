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
    public class EngineOilConfiguration : IEntityTypeConfiguration<EngineOil>
    {
        public void Configure(EntityTypeBuilder<EngineOil> builder)
        {
            builder.ToTable("EngineOil");

            builder.HasKey(x => x.Id);
        }
    }
}
