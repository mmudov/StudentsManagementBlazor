using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsManagementShared.Models;

namespace StudentsManagementShared.StudentRepository
{
    public interface IAcademicYearRepository
    {
        Task<AcademicYear> AddAsync(AcademicYear mod);
        Task<AcademicYear> UpdateAsync(AcademicYear mod);
        Task<AcademicYear> DeleteAsync(int id);
        Task<List<AcademicYear>> GetAllAsync();
        Task<AcademicYear> GetByIdAsync(int id);
        Task<AcademicYear> InactivateAcademicYearAsync(AcademicYear mod);
    }
}
