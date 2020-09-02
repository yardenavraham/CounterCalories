using BE;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ProjectContext : DbContext
    {
        
        public DbSet<User> Users { get; set; }
        public DbSet<Food> Foods { get; set; }
    }
}
