using GitHome.Models;
using System.Collections.Generic;

namespace GitHome.ViewModal
{
    public class UnitFormViewModel
    {
        public IEnumerable<Client> Clients { get; set; }

        public string Client { get; set; }
        public string Price { get; set; }

        public string Date { get; set; }

        public string Civic { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string YearBuilt { get; set; }
        public string Rooms { get; set; }
        public string Bedrooms { get; set; }
        public string Garages { get; set; }
        public string CentralAirCondition { get; set; }

        public string Description { get; set; }


        // public List<Image> -->

    }
}