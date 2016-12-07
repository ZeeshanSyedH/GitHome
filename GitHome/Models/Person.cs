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

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        public Person()
        {

        }

        public Person(string FirstName, string LastName, string email, string phoneNumber)
        {
            // INHEITED ATTIBUTES
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
        }
    }
}