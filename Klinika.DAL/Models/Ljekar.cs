using System;
using System.Collections.Generic;
using System.Text;

namespace Klinika.DAL.Models
{
   public class Ljekar : BaseEntity
    {
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public int Sifra { get; set; }

        public int TitulaID { get; set; }
        public Titula Titula { get; set; }

        public List<Prijem> Prijemi { get; set; }

    }
}
