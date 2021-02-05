using FluentValidation;
using Klinika.DAL.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Klinika.DAL.Validation
{
    public class PrijemValidator : AbstractValidator<Prijem>
    {
        public PrijemValidator()
        {
   
            RuleFor(model => model.DatumVrijeme)
             .GreaterThanOrEqualTo(DateTime.UtcNow)
                .WithMessage("Datum i vrijeme ne mogu biti iz proslosti!")
                
                ;
        }
    }
}
//                .GreaterThanOrEqualTo(DateTime.UtcNow)
