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
        public int securityQuestionID { get; set; }

        [Required]
        public DateTime joinedOn { get; set; }

        [Required]
        public bool isActive { get; set; }

        [Required]
        public int housesSold { get; set; }


        public Agent(int agentId, int securityQId, DateTime joinedOn, bool isActive, int housesSold, string firstName, string lastName, string email, int phoneNumber)
        {
            // AGENT SPECIFIC ATTRIBUTES
            this.AgentID = agentId;
            this.securityQuestionID = securityQId;
            this.joinedOn = joinedOn;
            this.isActive = isActive;
            this.housesSold = housesSold;
            // PERSON ATTIBUTES
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
        }
    }
}