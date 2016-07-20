using LibraryManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Repository
{
    public class DBContext: DbContext
    {
        public DBContext() : base("name=LibraryConnectionString") 
        {
        }

        public DbSet<User> User { get; set; }

        public DbSet<Book> Book { get; set; }

        public DbSet<CheckedBook> CheckedBook { get; set; }
    }
}
