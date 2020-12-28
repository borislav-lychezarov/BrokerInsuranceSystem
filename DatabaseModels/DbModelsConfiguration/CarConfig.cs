using DatabaseModels.Models.CarInsurances;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DatabaseModels.DbModelsConfiguration
{
    public class CarConfig : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasMany(x => x.Insurances)
                .WithOne(x => x.Car)
                .HasForeignKey(x => x.CarId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Owners)
                .WithOne(x => x.Car)
                .HasForeignKey(x => x.CarId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.Power)
                .HasPrecision(5, 2);
        }
    }
}
