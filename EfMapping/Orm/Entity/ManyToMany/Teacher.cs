using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfMapping.Orm.Entity.ManyToMany
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        public string TeacherName { get; set; }


        public virtual List<Student> Students { get; set; }
    }
}
