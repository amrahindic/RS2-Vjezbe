using eProdaja.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
   public interface IProizvodService
    {
        IEnumerable<Proizvod> Get();
        public Proizvod GetById(int Id);
        public Proizvod Insert(Proizvod proizvod);
        public Proizvod Update(int id, Proizvod proizvod);
    }
}
