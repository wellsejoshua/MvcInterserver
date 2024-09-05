using System.ComponentModel.DataAnnotations;

namespace MvcInterserver.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at most {1} characters", MinimumLength = 2)]
        public string? Name { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "The {0} must be at least {2} and at most {1} characters", MinimumLength = 2)]
        public string? Description { get; set; }
    }
}
