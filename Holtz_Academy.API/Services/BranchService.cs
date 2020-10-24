using Holtz_Academy.API.Data;
using Holtz_Academy.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holtz_Academy.API.Services
{
    public class BranchService
    {
        private readonly Context _context;
        public BranchService(Context context)
        {
            _context = context;
        }
        public async Task<List<Branch>> FindAllAsync()
        {
            return await _context.Branches.ToListAsync();
        }
        public async Task<Branch> FindByCodeAsync(int code)
        {
            return await _context.Branches.FirstOrDefaultAsync(x => x.BranchCode == code);
        }
        public async Task InsertAsync(Branch branch)
        {
            try
            {
                _context.Branches.Add(branch);
                await _context.SaveChangesAsync();
            }
            catch
            {

            }
        }
        public async Task UpdateAsync(Branch branch)
        {
            try
            {
                _context.Branches.Update(branch);
                await _context.SaveChangesAsync();
            }
            catch
            {

            }
        }
        public async Task RemoveAsync(int code)
        {
            Branch branch = await FindByCodeAsync(code);
            try
            {
                _context.Branches.Remove(branch);
                await _context.SaveChangesAsync();
            }
            catch
            {

            }
        }
    }
}
