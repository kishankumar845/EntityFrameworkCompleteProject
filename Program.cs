using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyDbContext db = new MyDbContext();
                Programme p = new Programme();
                p.Title = "B.Tech";
                p.Duration = 4;
                p.Fees = 500000;
                db.Programmes.Add(p);
                db.SaveChanges();
                Console.WriteLine("Database has been created Successfully...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exceptions are handled at best : "+ex.Message);
            }
        }    
    }
}
