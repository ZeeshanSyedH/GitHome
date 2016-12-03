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
        public int civicNumber { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string zipCode { get; set; }
    }
}