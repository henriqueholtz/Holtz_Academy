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
    public class StudentService
    {
        private readonly Context _context;
        public StudentService(Context context)
        {
            _context = context;
        }

        public async Task<List<Student>> FindAllAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> FindByCodeAsync(int code)
        {
            return await _context.Students.FirstOrDefaultAsync(x => x.StudentCode == code);
        }
        public async Task InsertAsync(Student student)
        {
            try
            {
                _context.Students.Add(student);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e) //comes from db
            {
                throw new IntegrityException(e.Message);
            }
        }
        public async Task UpdateAsync(Student student)
        {
            if (!await _context.Students.AnyAsync(x => x.StudentCode == student.StudentCode))
            {
                throw new NotFoundException("Don't have Student with this code");
            }
            try
            {
                _context.Students.Update(student);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e) //comes from db
            {
                throw new IntegrityException(e.Message);
            }
        }
        public async Task RemoveAsync(int code)
        {
            Student student = await FindByCodeAsync(code);
            if (student == null)
            {
                throw new NotFoundException("Don't have Student with this code");
            }
            try
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e) //comes from db
            {
                throw new IntegrityException(e.Message);
            }
        }
    }
}
