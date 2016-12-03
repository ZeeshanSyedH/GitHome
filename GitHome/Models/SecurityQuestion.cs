using System.ComponentModel.DataAnnotations;

namespace GitHome.Models
{
    public class SecurityQuestion
    {
        [Key]
        public int securityID { get; set; }
        public int AgentID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}