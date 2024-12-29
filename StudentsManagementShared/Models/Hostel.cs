using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagementShared.Models
{
    public class Hostel : UserCreateActivity
    {
        public int Id { get; set; }
        public string HostelName { get; set; }
        public int HostelTypeId { get; set; }
        public SystemCodeDetail HostelType { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
    }
}
