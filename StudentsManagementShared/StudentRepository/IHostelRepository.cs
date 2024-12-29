using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsManagementShared.Models;

namespace StudentsManagementShared.StudentRepository
{
    public interface IHostelRepository
    {
        Task<Hostel> AddAsync(Hostel mod);
        Task<Hostel> UpdateAsync(Hostel mod);
        Task<Hostel> DeleteAsync(int id);
        Task<List<Hostel>> GetAllAsync();
        Task<Hostel> GetByIdAsync(int id);
    }
}
