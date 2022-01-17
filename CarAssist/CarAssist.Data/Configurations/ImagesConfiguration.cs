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
    public class ImagesConfiguration : IEntityTypeConfiguration<Images>
    {
        public void Configure(EntityTypeBuilder<Images> builder)
        {
            builder.ToTable("Images");

            builder.HasKey(x => new { x.Id, x.VehicleId });

            builder.HasOne<Vehicle>(v=>v.Vehicle)
                .WithMany(x=>x.Images)
                .HasForeignKey(f=>f.VehicleId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
