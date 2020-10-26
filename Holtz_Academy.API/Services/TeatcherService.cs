using Holtz_Academy.API.Data;
using Holtz_Academy.API.Entities;
using Holtz_Academy.API.Services.Exceptions;
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

        public async Task<List<Teatcher>> FindAllAsync()
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
            catch (DbUpdateException e) //comes from db
            {
                throw new IntegrityException(e.Message);
            }
        }
        public async Task UpdateAsync(Teatcher teatcher)
        {
            if (!await _context.Teatchers.AnyAsync(x => x.TeatcherCode == teatcher.TeatcherCode))
            {
                throw new NotFoundException("Don't have Teatcher with this code");
            }
            try
            {
                _context.Teatchers.Update(teatcher);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e) //comes from db
            {
                throw new IntegrityException(e.Message);
            }
        }
        public async Task RemoveAsync(int code)
        {
            Teatcher teatcher = await FindByCodeAsync(code);
            if (teatcher == null)
            {
                throw new NotFoundException("Don't have Teatcher with this code");
            }
            try
            {
                _context.Teatchers.Remove(teatcher);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e) //comes from db
            {
                throw new IntegrityException(e.Message);
            }
        }
    }
}
