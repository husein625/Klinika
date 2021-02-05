using Klinika.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Klinika.DAL.Repository
{
   public interface IPrijemRepository 
    {
        IEnumerable<Prijem> GetAll();
        void Insert(Prijem entity);
        void Update(Prijem prijem, int id);
        Task Delete(int id);

    }
}
