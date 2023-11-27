﻿using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class MakeSeedConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
                new Make
                {
                    ID = 1,
                    Name = "BMW",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Make
                {
                    ID = 2,
                    Name = "Toyota",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}

