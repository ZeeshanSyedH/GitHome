using System.ComponentModel.DataAnnotations;

namespace GitHome.Models
{
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