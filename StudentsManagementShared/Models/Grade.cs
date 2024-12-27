using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagementShared.Models
{
    public class Grade : UserModifyActivity
    {
        public int Id { get; set; }
        public string GradeCode { get; set; }
        public string GradeName { get; set; }
        public string GradePoint { get; set; }
        public int MarkForm { get; set; }
        public int MarkTo { get; set; }
        public string Notes { get; set; }
    }
}
