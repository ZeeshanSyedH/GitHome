using System.ComponentModel.DataAnnotations;

namespace GitHome.Models
{

    /*
    * THIS CLASS IS THE ADDRESS CLASS WHICH DEFINES THE COMPONENTS OF AN ADDRESS(CIVIC,STREET,CITY,ZIPCODE)
    * EACH AGENT & CLIENT HAS AN ADDRESS
    */

    public class Address
    {
        [Key]
        public int addressID { get; set; }

        [Required]
        public int civicNumber { get; set; }

        [Required]
        [StringLength(40)]
        public string street { get; set; }

        [Required]
        [StringLength(40)]
        public string city { get; set; }

        [Required]
        [StringLength(6)]
        public string zipCode { get; set; }
    }
}