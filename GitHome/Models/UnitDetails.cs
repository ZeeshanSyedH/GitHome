using System.ComponentModel.DataAnnotations;

namespace GitHome.Models
{
    public class UnitDetails
    {
        [Key]
        public int unitDetailID { get; set; }

        public Address AddressID { get; set; }

        public int yearBuilt { get; set; }

        public int numRooms { get; set; }

        public int numBathrooms { get; set; }

        public int numBedrooms { get; set; }

        public int numGarageDoors { get; set; }

        public bool centralAirConditioning { get; set; }

        public string description { get; set; }

        // public List<Image> unitPicture { get; set; }

        public int askingPrice { get; set; }
    }
}