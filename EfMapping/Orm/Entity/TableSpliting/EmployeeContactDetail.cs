using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfMapping.Orm.Entity.TableSpliting
{
    public class EmployeeContactDetail
    {
        public int EmployeeId { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public Employee Employee { get; set; }
    }
}
