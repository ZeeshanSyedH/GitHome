using System;
using System.ComponentModel.DataAnnotations;

namespace GitHome.Models
{
    public class UnitProperties
    {
        [Key]
        public int unitDetailID { get; set; }

        [Required]
        public Address Address { get; set; }

        public int AddressID { get; set; }

        [Required]
        public bool forSale { get; set; }

        [Required]
        public int yearBuilt { get; set; }

        [Required]
        public int askingPrice { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string description { get; set; }

        public int numRooms { get; set; }

        public int numBedrooms { get; set; }

        public int numBathrooms { get; set; }

        public int numGarageDoors { get; set; }

        public bool centralAirConditioning { get; set; }

        // public List<Image> unitPicture { get; set; }

        public UnitProperties()
        {

        }

        public UnitProperties(Address newAddress, bool forSale, string yearBuilt,
                              string askingPrice, string title, string description,
                              string numRooms, string numBedrooms, string numBathrooms,
                              string numGarageDoors, bool centralAirConditioning)
        {
            this.Address = newAddress;
            this.forSale = forSale;
            this.yearBuilt = Convert.ToInt32(yearBuilt);
            this.askingPrice = Convert.ToInt32(askingPrice);
            this.Title = title;
            this.description = description;
            this.numRooms = Convert.ToInt32(numRooms);
            this.numBedrooms = Convert.ToInt32(numBedrooms);
            this.numBathrooms = Convert.ToInt32(numBathrooms);
            this.numGarageDoors = Convert.ToInt32(numGarageDoors);
            this.centralAirConditioning = centralAirConditioning;

        }

    }
}