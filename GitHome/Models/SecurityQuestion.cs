using System.ComponentModel.DataAnnotations;

namespace GitHome.Models
{

    /*
    * THIS CLASS IS THE SECURITY QUESTIONS CLASS WHICH DEFINES THE SECURITY QUESTIONS OF THE AGENTS ON GITHOME
    * ITS PURPOSE IS TO FACILITATE AN AGENT WHO HAS FORGOTTEN THEIR PASSWORD
    *      EACH SECUITY QUESTION WILL HAVE AN ASSOCIATED UNIQUE ID,
    *      AGENT WHO IT BELONGS TO, THE QUESTION & THE ANSWER
    */

    public class SecurityQuestion
    {
        [Key]
        public int securityID { get; set; }

        [Required]
        [StringLength(120)]
        public string Question { get; set; }

        [Required]
        [StringLength(120)]
        public string Answer { get; set; }


        public SecurityQuestion(int id, string question, string answer)
        {
            this.securityID = id;
            this.Question = question;
            this.Answer = answer;
        }
    }
}