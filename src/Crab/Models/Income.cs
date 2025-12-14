using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crab
{
    [Table("income")]
    public class Income
    {
        #region Consts & Static
        #endregion Consts & Static
        
        #region Fields & Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // Disable auto-increment
        public int Id { get; set; } = 1; // Only one record should ever exist.

        [Column(TypeName = "decimal(18,2)")]
        public decimal AnnualGross { get; set; }

        #endregion Fields & Properties
        
        #region Constructors
        #endregion Constructors
        
        #region Methods
        #endregion Methods
    }
}
