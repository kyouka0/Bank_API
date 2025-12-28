using Bank_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Bank_API.DB
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Account> accounts { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<BankCard> bankCards { get; set; }
        public DbSet<Branch> branches { get; set; }
        public DbSet<Transaction> transactions { get; set; }


    }
}
