using System.ComponentModel.DataAnnotations;

namespace GitHome.Models
{

    /*
    * THIS CLASS IS THE CLIENT CLASS WHICH DEFINES THE CLIENTS WHO'S HOUSES ARE AVAILABLE FOR SALE ON GITHOME
    * EACH CLIENT WILL HAVE AN ASSOCIATED UNIQUE ID,
    *      A FIRSTNAME & LASTNAME, AN OPTIONAL EMAIL ADDRESS & PHONE NUMBER
    */


    public class Client
    {
        [Key]
        public int clientID { get; set; }

        [Required]
        [StringLength(30)]
        public string clientFirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string clientLastName { get; set; }

        [StringLength(80)]
        public string clientEmail { get; set; }

        [Required]
        public int clientPhoneNumber { get; set; }
    }
}