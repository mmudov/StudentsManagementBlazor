using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsManagementShared.Models;

namespace StudentsManagementShared.StudentRepository
{
    public interface IGradeRepository
    {
        Task<Grade> AddAsync(Grade mod);
        Task<Grade> UpdateAsync(Grade mod);
        Task<Grade> DeleteAsync(int id);
        Task<List<Grade>> GetAllAsync();
        Task<Grade> GetByIdAsync(int id);
    }
}
