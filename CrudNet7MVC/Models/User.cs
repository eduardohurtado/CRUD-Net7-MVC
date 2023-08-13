using System.ComponentModel.DataAnnotations;

namespace CrudNet7MVC.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        [Required]
        public required string Phone { get; set; }
        [Required]
        public required string Email { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
