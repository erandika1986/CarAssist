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
    public class VehiclelConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.ToTable("Vehicle");

            builder.HasKey(x => new { x.Id, x.OwnerId });

            builder.HasOne<User>(u=>u.User)
                .WithMany(x=>x.Vehicles)
                .HasForeignKey(f=>f.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            /*builder.HasOne<VehicleType>(vt=>vt.VehicleType)
                .WithMany(x=>x.Vehicles)
                .HasForeignKey(f=>f.VehicleTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Feul>(f => f.Feul)
                .WithMany(x => x.Vehicles)
                .HasForeignKey(f => f.FeulId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Brand>(b => b.Brand)
                .WithMany(x => x.Vehicles)
                .HasForeignKey(f => f.BrandId)
                .OnDelete(DeleteBehavior.Restrict);*/

            builder.HasOne<VehicleType>(vt => vt.VehicleType)
                .WithOne(x => x.Vehicle)
                .HasForeignKey<VehicleType>(f => f.Id);


            builder.HasOne<Feul>(f => f.Feul)
                .WithOne(x => x.Vehicle)
                .HasForeignKey<Feul>(f => f.Id);

            builder.HasOne<Brand>(f => f.Brand)
                .WithOne(x => x.Vehicle)
                .HasForeignKey<Brand>(f => f.Id);

        }
    }
}
