using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace Crab
{
    // category
    [Table("categories")]
    [Index(nameof(Name), IsUnique = true)]
    public class Category
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

        public ICollection<Allocation> Allocations { get; set; } = new List<Allocation>();

        #endregion Fields & Properties
        
        #region Constructors
        #endregion Constructors
        
        #region Methods
        #endregion Methods
    }
}
