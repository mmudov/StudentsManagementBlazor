using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsManagementShared.Models;

namespace StudentsManagementShared.StudentRepository
{
    public interface ITeacherRepository
    {
        Task<Teacher> AddAsync(Teacher mod);

        Task<Teacher> UpdateAsync(Teacher mod);

        Task<Teacher> DeleteAsync(int id);

        Task<List<Teacher>> GetAllAsync();

        Task<Teacher> GetByIdAsync(int id);
    }
}
