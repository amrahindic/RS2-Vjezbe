using eProdaja.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ProizvodController : ControllerBase
    {

       public IProizvodService _proizvodService { get; set; }

        public ProizvodController(IProizvodService proizvodService)
        {
            _proizvodService = proizvodService;
        }

        [HttpGet]
        public IEnumerable<Proizvod> Get()
        {

           
            return _proizvodService.Get();
        }

        [HttpGet(template:"detalji/{id}")]
        public Proizvod GetById(int id)
        {
            return _proizvodService.GetById(id);
        }

        [HttpPost]
        public Proizvod Insert(Proizvod proizvod)
        {


            return _proizvodService.Insert(proizvod);
            
        }

        [HttpPut(template:"{id}")]
        public Proizvod Update(int id, Proizvod proizvod)
        {

            return _proizvodService.Update(id, proizvod);
        }
    }

    public class Proizvod
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

   
}
