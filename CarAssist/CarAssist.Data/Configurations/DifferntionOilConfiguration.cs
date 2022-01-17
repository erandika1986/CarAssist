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
    public class DifferntionOilConfiguration : IEntityTypeConfiguration<DifferntionOil>
    {
        public void Configure(EntityTypeBuilder<DifferntionOil> builder)
        {
            builder.ToTable("DifferntionOil");

            builder.HasKey(x => x.Id);
        }
    }
}
