using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class SystemContext : DbContext
    {
        public SystemContext()
           : base("DbConnection")
        { }
        static SystemContext()
        {
            Database.SetInitializer<SystemContext>(new DatabaseInitializer());
        }

        public DbSet<Article> Articles{ get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
