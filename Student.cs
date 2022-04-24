using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    internal class Student
    {
        //Scalar property
        public int StudentId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsBonafied { get; set; }
        public string ContactNo { get; set; }

        //Navigation property

        //This specifies Many to one relation --> many Students have one Programme to opt
        public virtual Programme Programme { get; set; } 
        //public virtual StudentAddress StudentAddress { get; set; }
    }
}
