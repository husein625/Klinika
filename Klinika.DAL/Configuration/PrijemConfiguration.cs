using Klinika.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Klinika.DAL.Configuration
{
  public   class PrijemConfiguration : BaseEntityConfiguration<Prijem>
    {
        public override void Configure(EntityTypeBuilder<Prijem> builder)
        {
            base.Configure(builder);


            builder.HasData(new List<Prijem> {
                new Prijem
                {
                    Id = 1,
                    DatumVrijeme = DateTime.UtcNow,
                    PacijentID = 1,
                    LjekarID = 3,
                    CreatedBy = "hmuftic"
                },
                new Prijem
                {
                    Id = 2,
                    DatumVrijeme = DateTime.UtcNow,
                    PacijentID = 2,
                    LjekarID = 1,
                    CreatedBy = "hmuftic"
                }, 
                new Prijem
                {
                    Id = 3,
                    DatumVrijeme = DateTime.UtcNow,
                    PacijentID = 3,
                    LjekarID = 1,
                    CreatedBy = "hmuftic"
                },
                new Prijem
                {
                    Id = 4,
                    DatumVrijeme = DateTime.UtcNow,
                    PacijentID = 2,
                    LjekarID = 2,
                    CreatedBy = "hmuftic"
                },
                });
        }
    }
}
