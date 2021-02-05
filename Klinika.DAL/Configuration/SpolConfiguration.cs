using Klinika.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Klinika.DAL.Configuration
{
   public class SpolConfiguration : BaseEntityConfiguration<Spol>
    {
        public override void Configure(EntityTypeBuilder<Spol> builder)
        {
            base.Configure(builder);

            builder.HasData(new List<Spol>
            {
                new Spol
                {
                    Id = 1,
                    Naziv = "Musko",
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic",

                },
                new Spol
                {
                    Id = 2,
                    Naziv = "Zensko",
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic",
                },
                new Spol
                {
                    Id = 3,
                    Naziv = "Nepoznato",
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic",
                }
            });
        }
    }
}
