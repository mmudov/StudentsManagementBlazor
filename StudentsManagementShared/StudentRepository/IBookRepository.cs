using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsManagementShared.Models;

namespace StudentsManagementShared.StudentRepository
{
    public interface IBookRepository
    {
        Task<Book> AddAsync(Book mod);
        Task<Book> UpdateAsync(Book mod);
        Task<Book> DeleteAsync(int id);
        Task<List<Book>> GetAllAsync();
        Task<Book> GetByIdAsync(int id);
    }
}
