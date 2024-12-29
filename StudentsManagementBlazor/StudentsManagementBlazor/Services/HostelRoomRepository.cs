using Microsoft.EntityFrameworkCore;
using StudentsManagementBlazor.Data;
using StudentsManagementShared.Models;
using StudentsManagementShared.StudentRepository;

namespace StudentsManagementBlazor.Services
{
    public class HostelRoomRepository : IHostelRoomRepository
    {
        private readonly ApplicationDbContext _context;

        public HostelRoomRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<HostelRoom> AddAsync(HostelRoom mod)
        {
           if (mod == null) return null;

            var newhostelroom = _context.HostelRooms.Add(mod).Entity;
            await _context.SaveChangesAsync();

            return newhostelroom;
        }

        public async Task<HostelRoom> DeleteAsync(int id)
        {
            var hostelroom = await _context.HostelRooms.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (hostelroom == null) return null;

            _context.HostelRooms.Remove(hostelroom);
            await _context.SaveChangesAsync();

            return hostelroom;
        }

        public async Task<List<HostelRoom>> GetAllAsync()
        {
            var hostelrooms = await _context.HostelRooms.ToListAsync();

            return hostelrooms;
        }

        public async Task<HostelRoom> GetByIdAsync(int id)
        {
            var hostelroom = await _context.HostelRooms.Where(x => x.Id == id).FirstOrDefaultAsync();

            if (hostelroom == null) return null;

            return hostelroom;
        }

        public async Task<HostelRoom> UpdateAsync(HostelRoom mod)
        {
            if (mod == null) return null;

            var updatedhostelroom = _context.HostelRooms.Update(mod).Entity;
            await _context.SaveChangesAsync();

            return updatedhostelroom;
        }
    }
}
