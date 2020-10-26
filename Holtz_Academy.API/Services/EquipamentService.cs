using Holtz_Academy.API.Data;
using Holtz_Academy.API.Entities;
using Holtz_Academy.API.Services.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holtz_Academy.API.Services
{
    public class EquipamentService
    {
        private readonly Context _context;
        public EquipamentService(Context context)
        {
            _context = context;
        }

        public async Task<List<Equipament>> FindAllAsync()
        {
            return await _context.Equipaments.ToListAsync();
        }
        public async Task<Equipament> FindByCodeAsync(int code)
        {
            return await _context.Equipaments.FirstOrDefaultAsync(x => x.EquipamentCode == code);
        }
        public async Task InsertAsync(Equipament equipament)
        {
            try
            {
                _context.Equipaments.Add(equipament);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e) //comes from db
            {
                throw new IntegrityException(e.Message);
            }
        }

        public async Task UpdateAsync(Equipament equipament)
        {
            if (!await _context.Equipaments.AnyAsync(x => x.EquipamentCode == equipament.EquipamentCode))
            {
                throw new NotFoundException("Don't have Equipament with this code");
            }
            try
            {
                _context.Equipaments.Update(equipament);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e) //comes from db
            {
                throw new IntegrityException(e.Message);
            }
        }

        public async Task RemoveAsync(int code)
        {
            Equipament equipament = await FindByCodeAsync(code);
            if (equipament == null)
            {
                throw new NotFoundException("Don't have Equipament with this code");
            }
            try
            {
                _context.Equipaments.Remove(equipament);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e) //comes from db
            {
                throw new IntegrityException(e.Message);
            }
        }
    }
}
