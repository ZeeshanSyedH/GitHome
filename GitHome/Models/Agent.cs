using System;
using System.ComponentModel.DataAnnotations;

namespace GitHome.Models
{
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