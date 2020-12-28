namespace BrokerInsuranceData
{
    using DatabaseModels.DbModelsConfiguration;
    using DatabaseModels.Models.CarInsurances;
    using DatabaseModels.Models.OwnerType;
    using DatabaseModels.Models.User;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class BrokerInsuranceDatabase : IdentityDbContext<ApplicationUser>
    {
        public BrokerInsuranceDatabase(DbContextOptions<BrokerInsuranceDatabase> options)
            :base(options)
        {

        }


        public DbSet<Insurance> Insurances { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Owner> Owners { get; set; }

        public DbSet<OwnerCar> OwnerCars { get; set; }

        public DbSet<LegalEntityOwner> LegalEntityOwners { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new InsuranceConfig());
            builder.ApplyConfiguration(new OwnerConfig());
            builder.ApplyConfiguration(new LegalEntityOwnerConfig());
            builder.ApplyConfiguration(new CarConfig());
            builder.ApplyConfiguration(new OwnerCarConfig());
            builder.ApplyConfiguration(new ApplicationUserConfig());

            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
