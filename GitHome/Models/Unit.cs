using System;
using System.ComponentModel.DataAnnotations;


namespace GitHome.Models
{
    public class Unit
    {
        [Key]
        public int unitID { get; set; }
        public ApplicationUser AgentID { get; set; }

        public int clientID { get; set; }

        public UnitDetails UnitDetailID { get; set; }

        public DateTime DateTime { get; set; }

    }




}