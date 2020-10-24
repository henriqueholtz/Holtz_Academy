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
    public class BranchesController : ControllerBase
    {
        private readonly BranchService _branchService;
        public BranchesController(BranchService branchService)
        {
            _branchService = branchService;
        }

        [HttpGet]
        public async Task<List<Branch>> FindAll()
        {
            return await _branchService.FindAllAsync();
        }

        [HttpGet("{code}")]
        public async Task<Branch> FindByCode(int code)
        {
            return await _branchService.FindByCodeAsync(code);
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] Branch branch)
        {
            await _branchService.InsertAsync(branch);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody]Branch branch)
        {
            await _branchService.UpdateAsync(branch);
            return Ok();
        }

        [HttpDelete("{code}")]
        public async Task<IActionResult> Delete(int code)
        {
            await _branchService.RemoveAsync(code);
            return Ok();
        }
    }
}
