using Klinika.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Klinika.DAL.Repository
{
    public interface INalazRepository
    {
        IEnumerable<Nalaz> GetAll();
        void Insert(Nalaz entity);
        void Update(Nalaz nalaz, int id);
        Task Delete(int id);
    }
}
