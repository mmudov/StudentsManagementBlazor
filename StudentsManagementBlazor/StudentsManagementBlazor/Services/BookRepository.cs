using Microsoft.EntityFrameworkCore;
using StudentsManagementBlazor.Data;
using StudentsManagementShared.Models;
using StudentsManagementShared.StudentRepository;

namespace StudentsManagementBlazor.Services
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        public async Task<Book> AddAsync(Book mod)
        {
            if (mod == null) return null;

            var data = _context.Books.Add(mod).Entity;
            await _context.SaveChangesAsync();

            return data;
        }

        public async Task<Book> DeleteAsync(int id)
        {
            var data = await _context.Books.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (data == null) return null;

            _context.Books.Remove(data);
            await _context.SaveChangesAsync();

            return data;
        }

        public async Task<List<Book>> GetAllAsync()
        {
            var data = await _context.Books.Include(x => x.BookCategory).ToListAsync();

            return data;
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            var data = await _context.Books.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (data == null) return null;

            return data;
        }

        public async Task<Book> UpdateAsync(Book mod)
        {
            if (mod == null) return null;

            var data = _context.Books.Update(mod).Entity;
            await _context.SaveChangesAsync();

            return data;
        }
    }
}
