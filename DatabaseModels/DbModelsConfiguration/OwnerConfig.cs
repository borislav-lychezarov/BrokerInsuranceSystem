using DatabaseModels.Models.OwnerType;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DatabaseModels.DbModelsConfiguration
{
    public class OwnerConfig : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {
            builder.HasMany(x => x.Cars)
                .WithOne(x => x.Owner)
                .HasForeignKey(x => x.OwnerId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
