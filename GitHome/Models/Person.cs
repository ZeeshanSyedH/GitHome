using System.ComponentModel.DataAnnotations;

namespace GitHome.Models
{
    public abstract class Person
    {
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

        [StringLength(80)]
        public string Email { get; set; }

        [Required]
        public int PhoneNumber { get; set; }
    }
}