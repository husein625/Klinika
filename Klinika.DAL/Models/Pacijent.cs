using System;
using System.Collections.Generic;
using System.Text;

namespace Klinika.DAL.Models
{
   public class Pacijent : BaseEntity
    {
        public String ImePrezime { get; set; }
        public DateTime DatumRođenja { get; set; }
        public String? Adresa { get; set; }
        public int? Telefon { get; set; }

        public int SpolID { get; set; }
        public Spol Spol { get; set; }

        public List<Prijem> Prijemi { get; set; }
    }
}
