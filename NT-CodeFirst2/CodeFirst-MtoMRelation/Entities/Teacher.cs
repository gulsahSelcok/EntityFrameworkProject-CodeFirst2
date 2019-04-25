using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_MtoMRelation.Entities
{
    public class Teacher
    {
        public Teacher()
        {
            this.students = new HashSet<Student>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual ICollection<Student> students { get; set; }
    }
}
