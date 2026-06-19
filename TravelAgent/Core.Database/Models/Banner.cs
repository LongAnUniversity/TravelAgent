using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Database.Models
{
    [Table("Banner")]
    public class Banner
    {
        [Key]
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Short { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? LinkUrl { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
