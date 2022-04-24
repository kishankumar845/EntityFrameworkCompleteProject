using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst
{
    class MyDbContext : DbContext
    {
        public MyDbContext() : base("StudentDB")  //this is our db name in the sql server
        {

        }
        public virtual DbSet<Programme> Programmes { get; set; } //if we not specify this table is not going to be created.
        //here we have to define atleast one class name because every table has relation now.
        public virtual DbSet<Student> Students { get; set; }
        //public virtual DbSet<StudentAddress> StudentAddresses { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }

        //we use virtual keyword to allow Lazy loading it is very important.
    }
}
