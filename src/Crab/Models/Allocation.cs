using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crab
{
    [Table("allocations")]
    public class Allocation
    {
        #region Consts & Static
        #endregion Consts & Static
        
        #region Fields & Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // Auto-increment
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public required string Name { get; set; }

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        public enum AllocationType
        {
            Expense,
            Savings,
        }

        public AllocationType Type { get; set; } = AllocationType.Expense;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        public enum AllocationFrequency
        {
            Monthly,
            BiMonthly,
            SemiAnnual,
            Annual,
        }

        public AllocationFrequency Frequency { get; set; } = AllocationFrequency.Monthly;

        public bool PreTaxed { get; set; } = false;

        #endregion Fields & Properties
        
        #region Constructors
        #endregion Constructors
        
        #region Methods
        #endregion Methods
    }
}
