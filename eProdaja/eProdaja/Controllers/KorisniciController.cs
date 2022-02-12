using eProdaja.Database;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KorisniciController : ControllerBase
    {
        public IKorisniciService _korisnikService;

        public KorisniciController(IKorisniciService korisnikService)
        {
            _korisnikService = korisnikService;
        }

        [HttpGet]
        public List<Model.Korisnici> Get()
        {


            return _korisnikService.GET();
        }


    }
}
