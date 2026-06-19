using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Database.Models
{
    [Table("Review")]
    public class Review
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }       
        public string? Position { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
