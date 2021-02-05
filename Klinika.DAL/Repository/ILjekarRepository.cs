using Klinika.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Klinika.DAL.Repository
{
    public interface ILjekarRepository
    {
        IEnumerable<Ljekar> GetAll();
        void Insert(Ljekar entity);
        void Update(Ljekar pacijent, int id);
        Task Delete(int id);
        public void GetById(int id);
    }
}
