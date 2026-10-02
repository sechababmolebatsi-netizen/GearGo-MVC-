using System.ComponentModel.DataAnnotations;

namespace GearGo.Models
{
    public class Equipment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Category { get; set; } = string.Empty;

        [Required]
        [Range(0.01, 50000.00)]
        [Display(Name = "Daily Rental Rate (ZAR)")]
        public decimal DailyRate { get; set; }

        [Required]
        [Display(Name = "Is Available")]
        public bool IsAvailable { get; set; }
    }
}
