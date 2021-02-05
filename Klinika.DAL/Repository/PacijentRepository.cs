using Klinika.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Klinika.DAL.Repository
{
    public class PacijentRepository : IPacijentRepository
    {
        private ApplicationDbContext _applicationDbContext;
        public PacijentRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task Delete(int id)
        {
           

            var pacijent =  _applicationDbContext.Pacijent.Find(id);
          await  _applicationDbContext.Pacijent.Include(e => e.Spol).FirstOrDefaultAsync(s => s.Id == id);

             _applicationDbContext.Pacijent.Remove(pacijent);
           await _applicationDbContext.SaveChangesAsync();
            
        }


        public IEnumerable<Pacijent> GetAll()
        {
            return _applicationDbContext.Pacijent.Include(e => e.Spol);
        }

        public void GetById(int id)
        {
            _applicationDbContext.Pacijent.Find(id);
        }

        public void Insert(Pacijent entity)
        {
            _applicationDbContext.Add(entity);
            _applicationDbContext.SaveChanges();

        }

        public void Update(Pacijent pacijent,int id)
        {
          //   _applicationDbContext.Pacijent.Find(id);
            _applicationDbContext.Update(pacijent);
           
            _applicationDbContext.SaveChanges();
            
        }
    }
}
