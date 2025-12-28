using Bank_API.Models;
using System.ComponentModel.DataAnnotations;

namespace Bank_API.DTO.Cusutomers
{
    public class GetCustomers
    {
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [MaxLength(15)]
        public string PhonNumber { get; set; }
        public int BanckCardId { get; set; }
        public List<GetCustomersWithAccount> accounts { get; set; }
        public GetCustomersWithBanckCard BankCard { get; set; }
    }
    public class GetCustomersWithAccount
    {
        public string AccountNumber { get; set; }
        public int Balance { get; set; }
    }
    public class GetCustomersWithBanckCard
    {
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }
    }
}
