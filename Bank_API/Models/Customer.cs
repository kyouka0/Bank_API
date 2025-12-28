using System.ComponentModel.DataAnnotations;

namespace Bank_API.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [MaxLength(15)]
        public string PhonNumber { get; set; }
        public int BanckCardId { get; set; }
        public List<Account> accounts { get; set; }
        public BankCard BankCard { get; set; }

    }
}
