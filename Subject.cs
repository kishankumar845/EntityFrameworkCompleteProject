using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    internal class Subject
    {
        //Scalar property
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        //Navigation property
        public virtual ICollection<Programme> Programmes { get; set; } //many to many
    }
}
