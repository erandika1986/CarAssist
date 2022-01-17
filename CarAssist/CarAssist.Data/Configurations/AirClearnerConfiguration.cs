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
    public class AirClearnerConfiguration : IEntityTypeConfiguration<AirClearner>
    {
        public void Configure(EntityTypeBuilder<AirClearner> builder)
        {
            builder.ToTable("AirClearner");

            builder.HasKey(x => x.Id);
        }
    }
}
