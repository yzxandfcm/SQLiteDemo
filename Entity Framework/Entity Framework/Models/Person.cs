using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    public class Person
    {
        public Int64 Id { get; set; } //注意要用Int64
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public PersonContext()
            : base("SqliteTest")
        {

        }
    }
}
