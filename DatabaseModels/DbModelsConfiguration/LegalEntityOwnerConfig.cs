﻿using DatabaseModels.Models.CarInsurances;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DatabaseModels.DbModelsConfiguration
{
    public class LegalEntityOwnerConfig : IEntityTypeConfiguration<OwnerCar>
    {
        public void Configure(EntityTypeBuilder<OwnerCar> builder)
        {
            builder.HasOne(x => x.Owner)
                .WithMany(x => x.Cars)
                .HasForeignKey(x => x.OwnerId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.LegalEntityOwner)
                .WithMany(x => x.Cars)
                .HasForeignKey(x => x.LegalEntityOwnerId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
