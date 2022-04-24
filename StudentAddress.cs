using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    internal class StudentAddress
    {
        //Scalar properties
        public int StudentId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }

        //Navigation properties
        //One to One with Student class
        //public virtual Student Student { get; set; } //encountered error
    }
}
