using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MyCmsContext:DbContext
    {
        public DbSet<BookGroup> BookGroups { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookComment> BookComments { get; set; }
    }
}
