using System.Collections.Generic;
using System.Drawing;

namespace GitHome.Models
{
    public class Unit
    {
        public int unitID { get; set; }

        public int agentID { get; set; }
        public int clientID { get; set; }
        public Address unitAddress { get; set; }
        public int yearBuilt { get; set; }
        public int numRooms { get; set; }
        public int numBathrooms { get; set; }
        public int numBedrooms { get; set; }
        public int numGarageDoors { get; set; }
        public bool centralAirConditioning { get; set; }
        public string description { get; set; }
        public List<Image> unitPicture { get; set; }
            
        public int askingPrice { get; set; }
    }
}