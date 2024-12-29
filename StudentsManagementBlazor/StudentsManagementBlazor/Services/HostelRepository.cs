using Microsoft.EntityFrameworkCore;
using StudentsManagementBlazor.Data;
using StudentsManagementShared.Models;
using StudentsManagementShared.StudentRepository;

namespace StudentsManagementBlazor.Services
{
    public class HostelRepository : IHostelRepository
    {
        private readonly ApplicationDbContext _context;

        public HostelRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<Hostel> AddAsync(Hostel mod)
        {
            mod.CreatedById = "MM";
            mod.CreatedOn = DateTime.Now;

            if (mod == null) return null;

            var newhostel = _context.Hostels.Add(mod).Entity;
            await _context.SaveChangesAsync();

            return newhostel;
        }

        public async Task<Hostel> DeleteAsync(int id)
        {
            var hostel = await _context.Hostels.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (hostel == null) return null;

            _context.Hostels.Remove(hostel);
            await _context.SaveChangesAsync();

            return hostel;
        }

        public async Task<List<Hostel>> GetAllAsync()
        {
            var hostels = await _context.Hostels.ToListAsync();

            return hostels;
        }

        public async Task<Hostel> GetByIdAsync(int id)
        {
            var hostel = await _context.Hostels.Where(x => x.Id == id).FirstOrDefaultAsync();

            if (hostel == null) return null;

            return hostel;
        }

        public async Task<Hostel> UpdateAsync(Hostel mod)
        {
            if (mod == null) return null;

            var updatedhostel = _context.Hostels.Update(mod).Entity;
            await _context.SaveChangesAsync();

            return updatedhostel;
        }
    }
}
