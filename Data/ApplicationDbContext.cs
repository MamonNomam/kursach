using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LiteTe.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Operation> Operations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Короткая запись
            modelBuilder.Entity<Operation>().ToTable(tb => tb.UseSqlOutputClause(false));
        }
        public virtual DbSet<OperationType> OperationTypes { get; set; }

        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<City> Cities { get; set; }
    }
}
