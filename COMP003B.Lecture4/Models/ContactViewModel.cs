using System.ComponentModel.DataAnnotations;

namespace COMP003B.Lecture4.Models
{
    public class ContactViewModel
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
