using Klinika.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Klinika.DAL.Configuration
{
   public class TitulaConfiguration : BaseEntityConfiguration<Titula>
    {
        public override void Configure(EntityTypeBuilder<Titula> builder)
        {
            base.Configure(builder);

            builder.HasData(new List<Titula> {
                new Titula
                {
                    Id = 1,
                    Naziv = "Specijalista",
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                } ,
                new Titula
                {
                    Id = 2,
                    Naziv = "Specijalizant",
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                },
                new Titula
                {
                    Id = 3,
                    Naziv = "Med Sestra",
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                },
                });
        }
    }
}
