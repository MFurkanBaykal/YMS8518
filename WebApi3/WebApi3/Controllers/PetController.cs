using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi3.Interface;

namespace WebApi3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly  IPetRepository _i;
        public PetController(IPetRepository i)
        {
            _i = i;
        }
        
        [HttpGet]
        public ActionResult Get()
        {
            return new JsonResult(_i.ToList());
        }

        
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return new JsonResult(_i.Get(id));
        }

        
        [HttpPost]
        public IActionResult Insert([FromBody]Model.Pet value)
        {
            _i.Insert(value);
            return new JsonResult(value);
        }

        [HttpPut("{id}")]
        public IActionResult Post([FromBody] Model.Pet value)
        {
            _i.Update(value);
            return new JsonResult(value);
        }

        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _i.Delete(id);
        }
    }
}