using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
   
        public ActionResult<IEnumerable<string>> GetAll()
        {
            return new string[] {"one", "two"} ;
        }


        [HttpGet("{id:int}")]
        public ActionResult<string> Get(int id)
        {
            return "rahat";
        }
    }
}