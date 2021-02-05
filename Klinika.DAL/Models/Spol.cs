using System;
using System.Collections.Generic;
using System.Text;

namespace Klinika.DAL.Models
{
   public class Spol : BaseEntity
    {
        public String Naziv { get; set; }
        public List<Pacijent> Pacijenti { get; set; }
    }
}
