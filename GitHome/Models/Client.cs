using System.ComponentModel.DataAnnotations;

namespace GitHome.Models
{

    /*
    * THIS CLASS IS THE CLIENT CLASS WHICH DEFINES THE CLIENTS WHO'S HOUSES ARE AVAILABLE FOR SALE ON GITHOME
    * EACH CLIENT WILL HAVE AN ASSOCIATED UNIQUE ID,
    *      A FIRSTNAME & LASTNAME, AN OPTIONAL EMAIL ADDRESS & PHONE NUMBER
    */


    public sealed class Client : Person
    {
        [Key]
        public int clientID { get; set; }
    }
}