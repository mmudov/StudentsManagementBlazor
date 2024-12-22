using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagementShared.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int NoOfCopy { get; set; }
        public int BookCategoryId {get; set;}
        public SystemCodeDetail BookCategory { get; set; }
    }
}
