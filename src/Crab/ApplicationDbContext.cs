using Microsoft.EntityFrameworkCore;

namespace Crab
{
    public class ApplicationDbContext : DbContext
    {
        #region Consts & Static
        #endregion Consts & Static
        
        #region Fields & Properties

        public DbSet<TaxProfile> TaxProfiles { get; set; }
        public DbSet<TaxBracket> TaxBrackets { get; set; }

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
            // When a TaxProfile is deleted, cascade delete all associated TaxBrackets
            // (tax brackets without a parent profile are meaningless orphaned data)
            modelBuilder.Entity<TaxProfile>()
                .HasMany(p => p.TaxBrackets)
                .WithOne(b => b.TaxProfile)
                .HasForeignKey(b => b.TaxProfileId)
                .OnDelete(DeleteBehavior.Cascade);

            // When a Category is deleted, set CategoryId to null on all associated Allocations
            // (allocations can exist without a category)
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Allocations)
                .WithOne(a => a.Category)
                .HasForeignKey(a => a.CategoryId)
                .OnDelete(DeleteBehavior.SetNull);
        }

        #endregion Methods
    }
}
