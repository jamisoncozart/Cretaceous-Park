using System.ComponentModel.DataAnnotations;

namespace CretaceousPark.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Names can only be 20 characters max.")]
        public string Name { get; set; }
        [Required]
        public string Species { get; set; }
        [Required]
        [Range(0, 200, ErrorMessage = "Age must be between 0 and 200.")]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}