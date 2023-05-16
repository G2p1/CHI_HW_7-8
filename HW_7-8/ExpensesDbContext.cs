using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HW_7_8
{
    public class ExpensesDbContext:DbContext
    {
        public DbSet<Expenses> Expenseses { get; set; }

        public ExpensesDbContext()
        {

        }
        public ExpensesDbContext(DbContextOptions<ExpensesDbContext> option)
            : base(option)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if (!optionBuilder.IsConfigured)
            {
                optionBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=home_accounting;Trusted_Connection=True;multipleactiveresultsets=True;TrustServerCertificate=True");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ExpensesDbContext).Assembly);
        }
    }
}
