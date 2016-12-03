namespace GitHome.Models
{

    /*
    * THIS CLASS IS THE CLIENT CLASS WHICH DEFINES THE CLIENTS WHO'S HOUSES ARE AVAILABLE FOR SALE ON GITHOME
    * EACH CLIENT WILL HAVE AN ASSOCIATED UNIQUE ID,
    *      A FIRSTNAME & LASTNAME, AN OPTIONAL EMAIL ADDRESS & PHONE NUMBER
    */


    public class Client
    {
        public int clientID { get; set; }
        public string clientFirstName { get; set; }
        public string clientLastName { get; set; }
        public string clientEmail { get; set; }
        public int clientPhoneNumber { get; set; }
    }
}