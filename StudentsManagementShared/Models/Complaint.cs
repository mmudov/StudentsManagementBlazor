﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagementShared.Models
{
    public class Complaint : UserModifyActivity
    {
        public int Id { get; set; }
        public int ComplaintId { get; set; }
        public int ComplaintTypeId { get; set; }
        public SystemCodeDetail ComplaintType { get; set; }
        public int SourceId { get; set; }
        public SystemCodeDetail Source { get; set; }
        public string ComplaintBy { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime ComplaintDate { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }
        public SystemCodeDetail Status { get; set; }
    }
}
