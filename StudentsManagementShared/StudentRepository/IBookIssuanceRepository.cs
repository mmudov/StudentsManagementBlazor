using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsManagementShared.Models;

namespace StudentsManagementShared.StudentRepository
{
    public interface IBookIssuanceRepository
    {
        Task<BookIssuance> AddAsync(BookIssuance mod);

        Task<BookIssuance> UpdateAsync(BookIssuance mod);

        Task<BookIssuance> DeleteAsync(int id);

        Task<List<BookIssuance>> GetAllAsync();

        Task<BookIssuance> GetByIdAsync(int id);
        Task<BookIssuance> ReturnBookUpdateAsync(BookIssuance mod);
    }
}
