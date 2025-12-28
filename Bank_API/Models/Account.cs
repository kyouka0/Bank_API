namespace Bank_API.Models
{
    public class Account
    {
        public int AccountId { get; set; }
        public string AccountNumber { get; set; }
        public int Balance { get; set; }
        public int CustomerId { get; set; }
        public List <Transaction> transactions { get; set; }
        public Customer Customer { get; set; }
    }
}
