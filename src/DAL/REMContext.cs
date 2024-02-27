using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class REMContext : DbContext
    {
        public REMContext()
        {
        }

        public REMContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Evaluation> Evaluations { get; set; }

        public DbSet<Report> Reports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-6149JFK;Initial Catalog=REMCheck;Integrated Security=True;Pooling=False");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
