using Klinika.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Klinika.DAL.Configuration
{
   public class LjekarConfiguration : BaseEntityConfiguration<Ljekar>
    {
        public override void Configure(EntityTypeBuilder<Ljekar> builder)
        {
            base.Configure(builder);
            builder.Property(b => b.Ime).IsRequired();
            builder.Property(b => b.Prezime).IsRequired();
            builder.Property(b => b.Sifra).IsRequired().HasMaxLength(10);

  
            builder.HasData(new List<Ljekar>
            {
                new Ljekar
                {
                    Id = 1,
                    Ime = "Husein",
                    Prezime = "Muftic",
                    Sifra = 0001,
                    TitulaID = 1,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"

                },
                new Ljekar
                {
                    Id = 2,
                    Ime = "Edin",
                    Prezime = "Malcinovic",
                    Sifra = 0002,
                    TitulaID = 2,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"

                },
                new Ljekar
                {
                    Id = 3,
                    Ime = "Ahmed",
                    Prezime = "Sehovic",
                    Sifra = 0003,
                    TitulaID = 3,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"

                }
            });


        }
    }
}
