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
    public class RevenueLicenceConfiguration : IEntityTypeConfiguration<RevenueLicence>
    {
        public void Configure(EntityTypeBuilder<RevenueLicence> builder)
        {
            builder.ToTable("RevenueLicence");

            builder.HasKey(x => x.Id);
        }
    }
}
