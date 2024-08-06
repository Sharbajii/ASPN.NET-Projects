using Microsoft.EntityFrameworkCore;

namespace TestASP_NET_CORE.Data
{
    public class TodoContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>()
                .HasKey(t => t._taskId); // Ensure TaskId is the primary key
            base.OnModelCreating(modelBuilder);
        }
    }
}




