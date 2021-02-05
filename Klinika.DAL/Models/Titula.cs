using System;
using System.Collections.Generic;
using System.Text;

namespace Klinika.DAL.Models
{
   public class Titula : BaseEntity
    {
        public String Naziv { get; set; }
        public List<Ljekar> Ljekari { get; set; }
    }
}
