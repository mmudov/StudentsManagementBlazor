using Microsoft.EntityFrameworkCore;
using StudentsManagementBlazor.Data;
using StudentsManagementShared.Models;
using StudentsManagementShared.StudentRepository;

namespace StudentsManagementBlazor.Services
{
    public class ComplaintActionRepository : IComplaintActionRepository
    {
        private readonly ApplicationDbContext _context;

        public ComplaintActionRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<ComplaintNote> AddAsync(ComplaintNote mod)
        {
            if (mod == null) return null;

            var complaintnote = _context.ComplaintNotes.Add(mod).Entity;
            await _context.SaveChangesAsync();

            return complaintnote;
        }

        public async Task<ComplaintNote> DeleteAsync(int id)
        {
            var complaintnote = await _context.ComplaintNotes.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (complaintnote == null) return null;

            _context.ComplaintNotes.Remove(complaintnote);
            await _context.SaveChangesAsync();

            return complaintnote;
        }

        public async Task<List<ComplaintNote>> GetAllAsync()
        {
            var complaintnote = await _context.ComplaintNotes.ToListAsync();

            return complaintnote;
        }

        public async Task<ComplaintNote> GetByIdAsync(int id)
        {
            var complaintnote = await _context.ComplaintNotes.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (complaintnote == null) return null;

            return complaintnote;
        }

        public async Task<ComplaintNote> UpdateAsync(ComplaintNote mod)
        {
            if (mod == null) return null;

            var complaintnote = _context.ComplaintNotes.Update(mod).Entity;
            await _context.SaveChangesAsync();

            return complaintnote;
        }
    }
}
