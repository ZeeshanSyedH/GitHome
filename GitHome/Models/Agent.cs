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

    public class Agent
    {
        [Key]
        public int AgentID { get; set; }

        public DateTime joinedOn { get; set; }

        public bool isActive { get; set; }
        public int housesSold { get; set; }

        public string agentFirstName { get; set; }
        public string agentLastName { get; set; }

        //public Image agentPicture { get; set; }
        public Address agentAddress { get; set; }

        public SecurityQuestion securityQuestions { get; set; }

    }
}