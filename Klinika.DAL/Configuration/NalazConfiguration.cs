using Klinika.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Klinika.DAL.Configuration
{
 public   class NalazConfiguration : BaseEntityConfiguration<Nalaz>
    {
        public override void Configure(EntityTypeBuilder<Nalaz> builder)
        {
            base.Configure(builder);

            builder.HasData(new List<Nalaz> {
            new Nalaz
            {
                Id = 1,
                Opis = "OpisNalaza",
                DatumVrijeme = DateTime.UtcNow,
                CreatedBy = "hmuftic",
                PrijemID = 1
            } ,

            new Nalaz
            {
                Id = 2,
                Opis = "OpisNalaza",
                DatumVrijeme = DateTime.UtcNow,
                CreatedBy = "hmuftic",
                 PrijemID = 2
            },
            });
        }
    }
}
