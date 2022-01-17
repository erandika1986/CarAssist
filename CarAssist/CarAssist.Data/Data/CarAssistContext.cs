using CarAssist.Data.Configurations;
using CarAssist.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssist.Data.Data
{
    public class CarAssistContext : DbContext
    {
        public CarAssistContext(DbContextOptions<CarAssistContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new VehiclelConfiguration());
            modelBuilder.ApplyConfiguration(new ImagesConfiguration());
            modelBuilder.ApplyConfiguration(new InsuranceConfiguration());
            modelBuilder.ApplyConfiguration(new RevenueLicenceConfiguration());
            modelBuilder.ApplyConfiguration(new EmissionTestConfiguration());
            modelBuilder.ApplyConfiguration(new EngineOilConfiguration());
            modelBuilder.ApplyConfiguration(new GearBoxOilConfiguration());
            modelBuilder.ApplyConfiguration(new DifferntionOilConfiguration());
            modelBuilder.ApplyConfiguration(new AirClearnerConfiguration());
            modelBuilder.ApplyConfiguration(new MaintanaceConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleTypeConfiguration());
            modelBuilder.ApplyConfiguration(new FeulConfiguration());
            modelBuilder.ApplyConfiguration(new BrandConfoguration());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles{ get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<Insurance> Insurances { get; set; }
        public DbSet<RevenueLicence> RevenueLicences { get; set; }
        public DbSet<EmissionTest> EmissionTests { get; set; }
        public DbSet<GearBoxOil> GearBoxOils { get; set; }
        public DbSet<EngineOil> EngineOils { get; set; }
        public DbSet<DifferntionOil> DifferntionOils { get; set; }
        public DbSet<AirClearner> AirClearners { get; set; }
        public DbSet<Maintanace> Maintanaces { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<Feul> Feuls { get; set; }
        public DbSet<Brand> Brands { get; set; }

    }
}
