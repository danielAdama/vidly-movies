using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class BaseEntity
    {
        [Required]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
