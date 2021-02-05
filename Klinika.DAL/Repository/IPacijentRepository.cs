using Klinika.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Klinika.DAL.Repository
{
    public interface IPacijentRepository 
    {
        IEnumerable<Pacijent> GetAll();
        void Insert(Pacijent entity);
        void Update(Pacijent pacijent, int id);
        Task  Delete(int id);
        public void GetById(int id);

    }
}
