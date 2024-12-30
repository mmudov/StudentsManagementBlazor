using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsManagementShared.Models;

namespace StudentsManagementShared.StudentRepository
{
    public interface IComplaintRepository
    {
        Task<Complaint> AddAsync(Complaint mod);
        Task<Complaint> UpdateAsync(Complaint mod);
        Task<Complaint> DeleteAsync(int id);
        Task<List<Complaint>> GetAllAsync();
        Task<Complaint> GetByIdAsync(int id);
    }
}
