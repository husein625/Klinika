using System;
using System.Collections.Generic;
using System.Text;

namespace Klinika.DAL.Models
{
  public abstract  class BaseEntity
    {
        public int Id { get; set; }
        public String CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }

        public BaseEntity()
        {
            CreatedAt = DateTime.UtcNow;
        }
    }
}
