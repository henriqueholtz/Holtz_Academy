using Holtz_Academy.API.Data;
using Holtz_Academy.API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holtz_Academy.API.Services
{
    public class TeatcherService
    {
        private readonly Context _context;
        public TeatcherService(Context context)
        {
            _context = context;
        }

        public async Task<ICollection<Teatcher>> FindAllAsync()
        {
            return await _context.Teatchers.ToListAsync();
        }

        public async Task<Teatcher> FindByCodeAsync(int code)
        {
            return await _context.Teatchers.FirstOrDefaultAsync(x => x.TeatcherCode == code);
        }

        public async Task InsertAsync(Teatcher teatcher)
        {
            try
            {
                _context.Teatchers.Add(teatcher);
                await _context.SaveChangesAsync();
            }
            catch
            {

            }
        }
        public async Task UpdateAsync(Teatcher teatcher)
        {
            try
            {
                _context.Teatchers.Update(teatcher);
                await _context.SaveChangesAsync();
            }
            catch
            {

            }
        }
        public async Task RemoveAsync(int code)
        {
            var teatcher = await FindByCodeAsync(code);
            if (teatcher == null)
            {
                
            }
            try
            {
                _context.Teatchers.Remove(teatcher);
                await _context.SaveChangesAsync();
            }
            catch
            {

            }
        }
    }
}
