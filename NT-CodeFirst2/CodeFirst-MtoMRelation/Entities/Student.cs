using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_MtoMRelation.Entities
{
    public class Student
    {
        public Student()
        {
            this.teachers = new HashSet<Teacher>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual ICollection<Teacher> teachers { get; set; }
        //ONEtoMANY relation. One student can have many teachers.
        //ONEtoMANY relation. One teacher can have many students.
        //= MANYtoMANY relation
    }
}
