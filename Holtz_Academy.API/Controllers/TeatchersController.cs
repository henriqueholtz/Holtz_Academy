using Holtz_Academy.API.Data;
using Holtz_Academy.API.Entities;
using Holtz_Academy.API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
        public async Task<List<Teatcher>> FindAll()
        {
            return await _teatcherService.FindAllAsync();
        }
        [HttpGet("{code}")]
        public async Task<Teatcher> FindByCode(int code)
        {
            return await _teatcherService.FindByCodeAsync(code);
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] Teatcher teatcher)
        {
            await _teatcherService.InsertAsync(teatcher);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Teatcher teatcher)
        {
            await _teatcherService.UpdateAsync(teatcher);
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
