using Klinika.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Klinika.DAL.Configuration
{
   public class PacijentConfiguration : BaseEntityConfiguration<Pacijent>
    {
        public override void Configure(EntityTypeBuilder<Pacijent> builder)
        {
            base.Configure(builder);

            builder.HasData(new List<Pacijent>
            {
                new Pacijent
                {
                    Id = 1,
                    ImePrezime ="Husein Muftić",
                    DatumRođenja = new DateTime(1998,10,25),
                    Adresa = "Breza",
                    Telefon = 062528494,
                    SpolID = 1,
                },
                new Pacijent
                {
                    Id = 2,
                    ImePrezime ="Eldin Velic",
                    DatumRođenja = new DateTime(1995,11,22),
                    Adresa = "Sarajevo",
                    Telefon = 062222494,
                    SpolID = 1,
                },
                new Pacijent
                {
                    Id = 3,
                    ImePrezime ="Elma Avdukic",
                    DatumRođenja = new DateTime(1995,11,22),
                    Adresa = "Sarajevo",
                    Telefon = 062222224,
                    SpolID = 2,
                }
            });



        }
    }
}
