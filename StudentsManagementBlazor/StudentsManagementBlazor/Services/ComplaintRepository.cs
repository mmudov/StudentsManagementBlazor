using Microsoft.EntityFrameworkCore;
using StudentsManagementBlazor.Data;
using StudentsManagementShared.Models;
using StudentsManagementShared.StudentRepository;

namespace StudentsManagementBlazor.Services
{
    public class ComplaintRepository : IComplaintRepository
    {
        private readonly ApplicationDbContext _context;

        public ComplaintRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<Complaint> AddAsync(Complaint mod)
        {
            mod.CreatedById = "MM";
            //mod.CreatedOn = DateTime.Now;
            mod.ModifiedById = "MM";
            //mod.ModifiedOn = DateTime.Now;

            if (mod == null) return null;

            var complaint = _context.Complaints.Add(mod).Entity;
            await _context.SaveChangesAsync();

            return complaint;
        }

        public async Task<Complaint> DeleteAsync(int id)
        {
            var complaint = await _context.Complaints.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (complaint == null) return null;

            _context.Complaints.Remove(complaint);
            await _context.SaveChangesAsync();

            return complaint;
        }

        public async Task<List<Complaint>> GetAllAsync()
        {
            var complaint = await _context.Complaints.ToListAsync();

            return complaint;
        }

        public async Task<Complaint> GetByIdAsync(int id)
        {
            var complaint = await _context.Complaints.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (complaint == null) return null;

            return complaint;
        }

        public async Task<Complaint> UpdateAsync(Complaint mod)
        {
            if (mod == null) return null;

            var complaint = _context.Complaints.Update(mod).Entity;
            await _context.SaveChangesAsync();

            return complaint;
        }
    }
}
