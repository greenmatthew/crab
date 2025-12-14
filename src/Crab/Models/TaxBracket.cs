using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crab
{
    [Table("tax_brackets")]
    public class TaxBracket
    {
        #region Consts & Static
        #endregion Consts & Static
        
        #region Fields & Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // Auto-increment
        public int Id { get; set; }

        [ForeignKey("TaxProfile")]
        public int TaxProfileId { get; set; }
        public required TaxProfile TaxProfile { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Required]
        public decimal RangeStart { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? RangeEnd { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Rate { get; set; }

        #endregion Fields & Properties
        
        #region Constructors
        #endregion Constructors
        
        #region Methods
        #endregion Methods
    }
}
