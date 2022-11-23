using System.ComponentModel.DataAnnotations;

namespace SixMinApi.Model
{
    public class Command
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? HowTo { get; set; }

        [Required]
        [MaxLength(20)]
        public string? Platform { get; set; }

        [Required]
        public string? CommandLine { get; set; }
    }
}
