using DatabaseModels.Models.CarInsurances;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DatabaseModels.DbModelsConfiguration
{
    public class InsuranceConfig : IEntityTypeConfiguration<Insurance>
    {
        public void Configure(EntityTypeBuilder<Insurance> builder)
        {
            builder.HasOne(x => x.Car)
                .WithMany(x => x.Insurances)
                .HasForeignKey(x => x.CarId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.IsCanceled)
                .HasDefaultValue(false);

            builder.Property(x => x.CreationDate)
                .HasDefaultValue(DateTime.UtcNow);

            builder.HasOne(x => x.Creator)
                .WithMany(x => x.Insurances)
                .HasForeignKey(x => x.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
