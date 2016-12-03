using System;
using System.ComponentModel.DataAnnotations;

namespace GitHome.Models
{

    /*
    * THIS CLASS IS THE AGENT CLASS WHICH DEFINES THE AGENT WHO WILL BE SELLING A HOUSE ON GITHOME
    * EACH AGENT WILL HAVE AN ASSOCIATED UNIQUE ID, 
    *      WHEN THEY JOINED GITHOME, IF THEY ARE ACTIVE(ALLOWED TO SELL ON GITHOME), NUMBER OF HOUSES THEY'VE SOLD, THEIR FIRSTNAME & LASTNAME,
    *      THEIR ADDRESS & SECURITY QUESTIONS TO RESET THEIR PASSWORD
    */

    public class Agent : Person
    {
        [Key]
        public int AgentID { get; set; }

        [Required]
        public DateTime joinedOn { get; set; }

        [Required]
        public bool isActive { get; set; }

        [Required]
        public int housesSold { get; set; }

        [Required]
        public SecurityQuestion securityQuestions { get; set; }

    }
}