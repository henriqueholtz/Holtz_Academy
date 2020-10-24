using Holtz_Academy.API.Data;
using Holtz_Academy.API.Entities;
using Holtz_Academy.API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
        public async Task<List<Student>> FindAll()
        {
            return await _studentService.FindAllAsync();
        }

        [HttpGet("{code}")]
        public async Task<Student> FindByCode(int code)
        {
            return await _studentService.FindByCodeAsync(code);
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody]Student student)
        {
            await _studentService.InsertAsync(student);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody]Student student)
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
