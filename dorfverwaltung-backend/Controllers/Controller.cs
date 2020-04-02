using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dorfverwaltung_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Controller : ControllerBase
    {

        // Response JSON data on https://localhost:5019 
        [HttpGet]
        public List<Dwarf> Get()
        {
            return Dwarf.DwarfDB;
        }
    }
}
