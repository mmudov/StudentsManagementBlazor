using Microsoft.EntityFrameworkCore;
using StudentsManagementBlazor.Data;
using StudentsManagementShared.Models;
using StudentsManagementShared.StudentRepository;

namespace StudentsManagementBlazor.Services
{
    public class AcademicYearRepository : IAcademicYearRepository
    {
        private readonly ApplicationDbContext _context;

        public AcademicYearRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<AcademicYear> AddAsync(AcademicYear mod)
        {
            if (mod == null) return null;

            var activeStatus = await _context.SystemCodeDetails
                .Include(x => x.SystemCode)
                .Where(x => x.SystemCode.Code == "AcademicYearStatus" && x.Code == "Active")
                .FirstOrDefaultAsync();

            mod.StatusId = activeStatus.Id;

            var academicyear = _context.AcademicYears.Add(mod).Entity;
            await _context.SaveChangesAsync();

            return academicyear;
        }

        public async Task<AcademicYear> DeleteAsync(int id)
        {
            var academicyear = await _context.AcademicYears.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (academicyear == null) return null;

            _context.AcademicYears.Remove(academicyear);
            await _context.SaveChangesAsync();

            return academicyear;
        }

        public async Task<List<AcademicYear>> GetAllAsync()
        {
            var academicyears = await _context.AcademicYears.Include(x => x.Status).ToListAsync();

            return academicyears;
        }

        public async Task<AcademicYear> GetByIdAsync(int id)
        {
            var academicyear = await _context.AcademicYears.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (academicyear == null) return null;

            return academicyear;
        }

        public async Task<AcademicYear> UpdateAsync(AcademicYear mod)
        {
            if (mod == null) return null;

            var academicyear = _context.AcademicYears.Update(mod).Entity;
            await _context.SaveChangesAsync();

            return academicyear;
        }

        public async Task<AcademicYear> InactivateAcademicYearAsync(AcademicYear mod)
        {
            if (mod == null) return null;

            var inactiveStatus = await _context.SystemCodeDetails
                .Include(x => x.SystemCode)
                .Where(x => x.SystemCode.Code == "AcademicYearStatus" && x.Code == "Inactive")
                .FirstOrDefaultAsync();

            mod.StatusId = inactiveStatus.Id;

            var data = _context.AcademicYears.Update(mod).Entity;
            await _context.SaveChangesAsync();

            return data;
        }
    }
}
