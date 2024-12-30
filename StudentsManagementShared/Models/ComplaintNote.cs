using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagementShared.Models
{
    public class ComplaintNote
    {
        public int Id { get; set; }
        public int ComplaintId { get; set; }
        public Complaint Complaint { get; set; }
        public string Notes { get; set; }
        public string Attachment { get; set; }
        public DateTime ActionedOn { get; set; }
        public int ActionStatusId { get; set; }
        public SystemCodeDetail ActionStatus { get; set; }
    }
}
