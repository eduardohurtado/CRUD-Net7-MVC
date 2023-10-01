using System.ComponentModel.DataAnnotations;

namespace CrudNet7MVC.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "Name is required")]
        public required string Name { get; set; }

        [Required (ErrorMessage = "Phone is required")]
        public required string Phone { get; set; }

        [Required (ErrorMessage = "Email is required")]
        public required string Email { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
