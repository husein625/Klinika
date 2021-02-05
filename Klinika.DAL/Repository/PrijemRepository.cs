using Klinika.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Klinika.DAL.Repository
{
   public class PrijemRepository : IPrijemRepository
    {
        private ApplicationDbContext _applicationDbContext;
        public PrijemRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task Delete(int id)
        {


            var prijem = _applicationDbContext.Prijem.Find(id);
            await _applicationDbContext.Prijem.Include(e => e.Ljekar).Include(a => a.Pacijent).FirstOrDefaultAsync(s => s.Id == id);

            _applicationDbContext.Prijem.Remove(prijem);
            await _applicationDbContext.SaveChangesAsync();

        }

        public IEnumerable<Prijem> GetAll()
        {
            return _applicationDbContext.Prijem.Include(e =>e.Ljekar).Include(a => a.Pacijent);
        }

        public void Insert(Prijem entity)
        {
            _applicationDbContext.Add(entity);
            _applicationDbContext.SaveChanges();

        }


        public void Update(Prijem prijem, int id)
        {
            _applicationDbContext.Update(prijem);

            _applicationDbContext.SaveChanges();

        }
    }
}
