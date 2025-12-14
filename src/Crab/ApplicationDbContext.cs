using Microsoft.EntityFrameworkCore;

namespace Crab
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        #region Consts & Static
        #endregion Consts & Static
        
        #region Fields & Properties

        public DbSet<Category> Categories { get; set; }
        public DbSet<Allocation> Allocations { get; set; }

        #endregion Fields & Properties
        
        #region Constructors
        #endregion Constructors
        
        #region Methods

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=budget.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Allocations)
                .WithOne(a => a.Category)
                .HasForeignKey(a => a.CategoryId)
                .OnDelete(DeleteBehavior.SetNull);
        }

        #endregion Methods
    }
}
