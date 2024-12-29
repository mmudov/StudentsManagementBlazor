using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsManagementShared.Models;

namespace StudentsManagementShared.StudentRepository
{
    public  interface IHostelRoomRepository
    {
        Task<HostelRoom> AddAsync(HostelRoom mod);
        Task<HostelRoom> UpdateAsync(HostelRoom mod);
        Task<HostelRoom> DeleteAsync(int id);
        Task<List<HostelRoom>> GetAllAsync();
        Task<HostelRoom> GetByIdAsync(int id);
    }
}
