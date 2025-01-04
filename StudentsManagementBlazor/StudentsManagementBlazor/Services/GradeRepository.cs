using Microsoft.EntityFrameworkCore;
using StudentsManagementBlazor.Data;
using StudentsManagementShared.Models;
using StudentsManagementShared.StudentRepository;

namespace StudentsManagementBlazor.Services
{
    public class GradeRepository : IGradeRepository
    {
        private readonly ApplicationDbContext _context;

        public GradeRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<Grade> AddAsync(Grade mod)
        {
            mod.CreatedById = "MM";
            //mod.CreatedOn = DateTime.Now;
            mod.ModifiedById = "MM";
            //mod.ModifiedOn = DateTime.Now;

            if (mod == null) return null;

            var newgrade = _context.Grades.Add(mod).Entity;
            await _context.SaveChangesAsync();

            return newgrade;
        }

        public async Task<Grade> DeleteAsync(int id)
        {
            var grade = await _context.Grades.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (grade == null) return null;

            _context.Grades.Remove(grade);
            await _context.SaveChangesAsync();

            return grade;
        }

        public async Task<List<Grade>> GetAllAsync()
        {
            var grades = await _context.Grades.ToListAsync();

            return grades;
        }

        public async Task<Grade> GetByIdAsync(int id)
        {
            var grade = await _context.Grades.Where(x => x.Id == id).FirstOrDefaultAsync();
            
            if (grade == null) return null;

            return grade;
        }

        public async Task<Grade> UpdateAsync(Grade mod)
        {
            if (mod == null) return null;

            var updatedgrade = _context.Grades.Update(mod).Entity;
            await _context.SaveChangesAsync();

            return updatedgrade;
        }
    }
}
