namespace Bank_API.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public string Date { get; set; }
        public int AccountId { get; set; }
    }
}
