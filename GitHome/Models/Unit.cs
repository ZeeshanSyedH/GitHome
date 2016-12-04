using System;
using System.ComponentModel.DataAnnotations;


namespace GitHome.Models
{

    /*
     * THIS CLASS IS THE UNIT CLASS WHICH DEFINED THE UNITS OR HOUSES WHICH WILL BE ENTERED INTO GITHOME
     * EACH UNIT(HOUSE) WILL HAVE AN ASSOCIATED UNIQUE ID,
     *      AGENT WHO IS SELLING IT, CLIENT WHO IT BELONG TO, UNITDETAILS WHICH DEFINES THE ATTRIBUTES OF THE HOUSE, & THE DATE OF UNOCCUPATION (When you can move in)
     */


    public sealed class Unit
    {
        [Key]
        public int unitID { get; set; }

        [Required]
        public String AgentID { get; set; }

        [Required]
        public int clientID { get; set; }

        [Required]
        public UnitDetails UnitDetailID { get; set; }

        [Required]
        public DateTime AvailableFrom { get; set; }
    }




}