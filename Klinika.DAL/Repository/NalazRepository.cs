using Klinika.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika.DAL.Repository
{
    public class NalazRepository : INalazRepository
    {
        ApplicationDbContext _applicationDbContext;
        public NalazRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task Delete(int id)
        {

            var nalaz = _applicationDbContext.Nalaz.Find(id);
            await _applicationDbContext.Nalaz.Include(e => e.Prijem).FirstOrDefaultAsync(s => s.Id == id);

            _applicationDbContext.Nalaz.Remove(nalaz);
            await _applicationDbContext.SaveChangesAsync();
        }

        public IEnumerable<Nalaz> GetAll()
        {
            var get = _applicationDbContext.Nalaz.Include(e => e.Prijem);
            return get;
        }


        public void Insert(Nalaz entity)
        {
            _applicationDbContext.Add(entity);
            _applicationDbContext.SaveChanges();
        }

        public void Update(Nalaz nalaz, int id)
        {
            _applicationDbContext.Update(nalaz);

            _applicationDbContext.SaveChanges();
        }
    }
}
