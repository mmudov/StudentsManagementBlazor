using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsManagementShared.Models;

namespace StudentsManagementShared.StudentRepository
{
    public interface IDepartmentRepository
    {
        Task<Department> AddAsync(Department mod);
        Task<Department> UpdateAsync(Department mod);
        Task<Department> DeleteAsync(int id);
        Task<List<Department>> GetAllAsync();
        Task<Department> GetByIdAsync(int id);
    }
}
