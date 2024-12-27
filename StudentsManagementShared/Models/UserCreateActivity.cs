using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagementShared.Models
{
    public class UserCreateActivity
    {
        public string CreatedById { get; set; }
        public DateTime CreatedOn { get; set; }
    }

    public class UserModifyActivity : UserCreateActivity
    {
        public string ModifiedById { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
