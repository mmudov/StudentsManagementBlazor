using Microsoft.EntityFrameworkCore;
using StudentsManagementBlazor.Data;
using StudentsManagementShared.Models;
using StudentsManagementShared.StudentRepository;

namespace StudentsManagementBlazor.Services
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext _context;

        public DepartmentRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<Department> AddAsync(Department mod)
        {
            mod.CreatedById = "MM";
            //mod.CreatedOn = DateTime.Now;

            if (mod == null) return null;

            var department = _context.Departments.Add(mod).Entity;
            await _context.SaveChangesAsync();

            return department;
        }

        public async Task<Department> DeleteAsync(int id)
        {
            var department = await _context.Departments.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (department == null) return null;

            _context.Departments.Remove(department);
            await _context.SaveChangesAsync();

            return department;
        }

        public async Task<List<Department>> GetAllAsync()
        {
            var department = await _context.Departments.ToListAsync();

            return department;
        }

        public async Task<Department> GetByIdAsync(int id)
        {
            var department = await _context.Departments.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (department == null) return null;

            return department;
        }

        public async Task<Department> UpdateAsync(Department mod)
        {
            if (mod == null) return null;

            var department = _context.Departments.Update(mod).Entity;
            await _context.SaveChangesAsync();

            return department;
        }
    }
}
