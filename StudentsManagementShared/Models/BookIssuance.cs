using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsManagementBlazor.Shared.Models;

namespace StudentsManagementShared.Models
{
    public class BookIssuance : UserCreateActivity
    {
        public int Id { get; set; }
        public DateTime IssueData { get; set; }
        public DateTime DueData { get; set; }
        public DateTime? ReturnData { get; set; }
        public int ClassId { get; set; }
        public SystemCodeDetail Class { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public string Notes { get; set; }
        public int StatusId { get; set; }
        public SystemCodeDetail Status { get; set; }
    }
}
