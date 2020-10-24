using Holtz_Academy.API.Data;
using Holtz_Academy.API.Entities;
using Holtz_Academy.API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Holtz_Academy.API.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        private readonly StudentService _studentService;
        public StudentsController(StudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _studentService.FindAllAsync()); ;
        }

        [HttpGet("{code}")]
        public async Task<IActionResult> Index(int code)
        {
            return Ok(await _studentService.FindByCodeAsync(code));
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody]Student student)
        {
            await _studentService.InsertAsync(student);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Edit(Student student)
        {
            await _studentService.UpdateAsync(student);
            return Ok();
        }

        [HttpDelete("{code}")]
        public async Task<IActionResult> Delete(int code)
        {
            await _studentService.RemoveAsync(code);
            return Ok();
        }
    }
}
