using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace GitHome.ViewModal
{
    public class UnitFormViewModel
    {
        public IEnumerable<SelectListItem> Clients { get; set; }

        [Display(Name = "Client")]
        public int SelectedClientId { get; set; }

        //[Required]
        //public string Client { get; set; }

        // UNIT INFORMATION
        [Required]
        public string Price { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        public string Time = "12:00";

        // ADDRESS INFORMATION
        [Required]
        public string Civic { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string ZipCode { get; set; }

        [Required]
        public string YearBuilt { get; set; }

        // PROPERTY DETAILS
        [Required]
        public string Rooms { get; set; }

        [Required]
        public string Bedrooms { get; set; }

        [Required]
        public string Bathrooms { get; set; }

        [Required]
        public string Garages { get; set; }

        public bool CentralAirCondition { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }


        // public List<Image> -->

    }
}