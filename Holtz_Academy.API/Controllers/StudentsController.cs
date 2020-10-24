using Holtz_Academy.API.Data;
using Holtz_Academy.API.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Holtz_Academy.API.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        private readonly Context _context;
        public StudentsController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Students.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_context.Students.FirstOrDefault(x => x.StudentCode == id));
        }

        [HttpPost]
        public IActionResult Insert([FromBody]Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public IActionResult Edit(int id)
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
