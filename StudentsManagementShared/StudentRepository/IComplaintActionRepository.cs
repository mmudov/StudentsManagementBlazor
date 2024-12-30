using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsManagementShared.Models;

namespace StudentsManagementShared.StudentRepository
{
    public interface IComplaintActionRepository
    {
        Task<ComplaintNote> AddAsync(ComplaintNote mod);
        Task<ComplaintNote> UpdateAsync(ComplaintNote mod);
        Task<ComplaintNote> DeleteAsync(int id);
        Task<List<ComplaintNote>> GetAllAsync();
        Task<ComplaintNote> GetByIdAsync(int id);
    }
}
