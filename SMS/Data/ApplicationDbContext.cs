using Microsoft.EntityFrameworkCore;
using SMS.Model;

namespace SMS.Data
{
    public class ApplicationDbContext:DbContext //DbContext is the class provided by Entity Framework Core directive
    {
        public DbSet<Student>Students { get; set; }
        
        public DbSet<login> Login { get; set; }
        public DbSet<Register> Register { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public ApplicationDbContext()
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Student>().ToTable("tblStudent");
        }
    }
}
