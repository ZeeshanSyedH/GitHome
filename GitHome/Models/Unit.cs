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
        public int ID { get; set; }

        public Agent Agent { get; set; }

        [Required]
        public int AgentId { get; set; }

        public UnitProperties UnitDetail { get; set; }

        [Required]
        public int UnitDetailID { get; set; }

        [Required]
        public DateTime availableFrom { get; set; }

        public Unit()
        {
        }

        public Unit(int refAgent, int refUnitDetail, DateTime availableFrom)
        {
            this.AgentId = refAgent;
            this.UnitDetailID = refUnitDetail;
            this.availableFrom = availableFrom;
        }
    }
}