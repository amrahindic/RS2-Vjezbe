using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    //[ApiController]
    //[Route("[controller]")]
    public class VrsteProizvodumController:BaseReadController<Model.VrsteProizvoda, object>
    {
        
        public VrsteProizvodumController(IVrsteProizvodaService service) : base(service)
        {
           
        }

       

    }
}
