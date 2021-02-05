using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Klinika.DAL.Models
{
    public class Nalaz : BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public String Opis { get; set; }
        public DateTime DatumVrijeme { get; set; }

        public int PrijemID { get; set; }
        public Prijem Prijem { get; set; }

        public Nalaz()
        {
            DatumVrijeme = DateTime.UtcNow;
        }
    }
}
