using Klinika.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Klinika.DAL.Repository
{
   public class LjekarRepository : ILjekarRepository
    {
        private ApplicationDbContext _applicationDbContext;
        public LjekarRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task Delete(int id)
        {
        

            var ljekar = _applicationDbContext.Ljekar.Find(id);
            await _applicationDbContext.Ljekar.Include(e => e.Titula).FirstOrDefaultAsync(s => s.Id == id);

            _applicationDbContext.Ljekar.Remove(ljekar);
            await _applicationDbContext.SaveChangesAsync();

        }


        public IEnumerable<Ljekar> GetAll()
        {
            return _applicationDbContext.Ljekar.Include(e => e.Titula);
        }

        public void GetById(int id)
        {
            _applicationDbContext.Ljekar.Find(id);
        }

        public void Insert(Ljekar entity)
        {
            _applicationDbContext.Add(entity);
            _applicationDbContext.SaveChanges();

        }

        public void Update(Ljekar ljekar, int id)
        {
            _applicationDbContext.Update(ljekar);

            _applicationDbContext.SaveChanges();

        }
    }
}
