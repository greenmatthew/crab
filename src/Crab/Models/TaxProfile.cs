using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace Crab
{
    [Table("tax_profiles")]
    [Index(nameof(Name), IsUnique = true)]
    public class TaxProfile
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

        [Column(TypeName = "decimal(18,2)")]
        public decimal StandardDeduction { get; set; }

        public ICollection<TaxBracket> TaxBrackets { get; set; } = new List<TaxBracket>();

        #endregion Fields & Properties
        
        #region Constructors
        #endregion Constructors
        
        #region Methods
        #endregion Methods
    }
}
