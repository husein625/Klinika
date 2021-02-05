using System;
using System.Collections.Generic;
using System.Text;

namespace Klinika.DAL.Models
{
   public class Prijem : BaseEntity
    {
        public DateTime DatumVrijeme { get; set; }
        public Boolean HitniPrijem { get; set; }

        public int PacijentID { get; set; }
        public Pacijent Pacijent { get; set; }

        public int LjekarID { get; set; }
        public Ljekar Ljekar { get; set; }

        public List<Nalaz> Nalazi { get; set; }
    }
}
