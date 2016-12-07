using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GitHome.Models
{

    /*
    * THIS CLASS IS THE AGENT CLASS WHICH DEFINES THE AGENT WHO WILL BE SELLING A HOUSE ON GITHOME
    * EACH AGENT WILL HAVE AN ASSOCIATED UNIQUE ID, 
    *      WHEN THEY JOINED GITHOME, IF THEY ARE ACTIVE(ALLOWED TO SELL ON GITHOME), NUMBER OF HOUSES THEY'VE SOLD, THEIR FIRSTNAME & LASTNAME,
    *      THEIR ADDRESS & SECURITY QUESTIONS TO RESET THEIR PASSWORD
    */

    public sealed class Agent : Person
    {
        [Key]
        public int AgentId { get; set; }

        [Required]
        public DateTime joinedOn { get; set; }

        [Required]
        public bool isActive { get; set; }

        [Required]
        public int housesSold { get; set; }

        public List<Client> Clients { get; set; }

        public Agent()
        {

        }

        public Agent(string FirstName, string LastName, string email, string phoneNumber) : base(FirstName, LastName, email, phoneNumber)
        {
            this.joinedOn = DateTime.Now;
            this.isActive = true;
            this.housesSold = 0;
        }


    }
}