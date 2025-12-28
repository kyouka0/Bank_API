namespace Bank_API.Models
{
    public class BankCard
    {
        public int BankCardId { get; set; }
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
