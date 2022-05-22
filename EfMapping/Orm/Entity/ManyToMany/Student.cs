using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfMapping.Orm.Entity.ManyToMany
{
    //Students-teachers arasında many to many bir ilişki vardır. Şu şekilde sağlanır.
    public class Student
    {
        public int StudentId { get; set; }

        public string StudentName { get; set; }



        public virtual List<Teacher> Teachers { get; set; }
    }
}
