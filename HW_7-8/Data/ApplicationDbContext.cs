using Microsoft.EntityFrameworkCore;

namespace HW_7_8.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Expenses> expenses { get; set; }
        public DbSet<Category> categories { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, ExpensesCategory = "food" },
                new Category { Id = 2, ExpensesCategory = "transport" },
                new Category { Id = 3, ExpensesCategory = "mobile comunication" },
                new Category { Id = 4, ExpensesCategory = "internet" },
                new Category { Id = 5, ExpensesCategory = "entartainment" }
            );
        }
    }
}
