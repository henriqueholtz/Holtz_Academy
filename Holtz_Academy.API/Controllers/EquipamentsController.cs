using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Holtz_Academy.API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Holtz_Academy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipamentsController : ControllerBase
    {
        private readonly Context _context;
        public EquipamentsController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Equipaments.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_context.Equipaments.FirstOrDefault(x => x.EquipamentCode == id));
        }

        [HttpPost("{id}")]
        public IActionResult Post(int id)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
