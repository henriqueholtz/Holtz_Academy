using Holtz_Academy.API.Data;
using Holtz_Academy.API.Entities;
using Holtz_Academy.API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Holtz_Academy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeatchersController : ControllerBase
    {
        private readonly TeatcherService _teatcherService;
        public TeatchersController(TeatcherService service)
        {
            _teatcherService = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_teatcherService.FindAllAsync());
        }
        [HttpGet("{code}")]
        public IActionResult Get(int code)
        {
            return Ok(_teatcherService.FindByCodeAsync(code));
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] Teatcher teatcher)
        {
            await _teatcherService.InsertAsync(teatcher);
            return Ok();
        }

        [HttpPut]
        public IActionResult Edit(int code)
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] int code)
        {
            await _teatcherService.RemoveAsync(code);
            return Ok();
        }
    }
}
