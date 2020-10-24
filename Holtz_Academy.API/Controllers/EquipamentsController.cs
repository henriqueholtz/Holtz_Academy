using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Holtz_Academy.API.Data;
using Holtz_Academy.API.Entities;
using Holtz_Academy.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Holtz_Academy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipamentsController : ControllerBase
    {
        private readonly EquipamentService _equipamentService;
        public EquipamentsController(EquipamentService equipamentService)
        {
            _equipamentService = equipamentService;
        }

        [HttpGet]
        public async Task<List<Equipament>> FindAll()
        {
            return await _equipamentService.FindAllAsync();
        }

        [HttpGet("{code}")]
        public async Task<Equipament> FindByCode([FromBody]int code)
        {
            return await _equipamentService.FindByCodeAsync(code);
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody]Equipament equipament)
        {
            await _equipamentService.InsertAsync(equipament);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Equipament equipament)
        {
            await _equipamentService.UpdateAsync(equipament);
            return Ok();
        }

        [HttpDelete("{code}")]
        public async Task<IActionResult> Delete(int code)
        {
            await _equipamentService.RemoveAsync(code);
            return Ok();
        }
    }
}
