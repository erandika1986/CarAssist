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
    public class MaintanaceConfiguration : IEntityTypeConfiguration<Maintanace>
    {
        public void Configure(EntityTypeBuilder<Maintanace> builder)
        {
            builder.ToTable("Maintanace");

            builder.HasKey(x => x.Id);
        }
    }
}
