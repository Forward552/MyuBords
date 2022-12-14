using Microsoft.EntityFrameworkCore;

namespace MyuBords.Entities
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<WorkItem> WorkItems { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }



    }
}
