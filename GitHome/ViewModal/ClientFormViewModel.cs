using System.ComponentModel.DataAnnotations;

namespace GitHome.ViewModal
{
    public class ClientFormViewModel
    {
        //CLIENT INFORMATION 
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
    }
}