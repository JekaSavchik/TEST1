using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Entity_test2
{
    class UserContext : DbContext
    {
        public UserContext() : base("UsersDB")
        { }
        public DbSet<User> Users {get;set;}
    }
}
