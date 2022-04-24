using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    internal class Programme    
    {
        //Scalar properties

        public int ID { get; set; }  //PK Programme ID
        public string Title { get; set; }   
        public int Duration { get; set; }   
        public float Fees { get; set; } 

        //Navigation property
        public virtual ICollection<Student> Students { get; set; } //Programme has One to many relation btwn Student
        public virtual ICollection<Subject> Subjects { get; set; } //Many to many
    }
}
