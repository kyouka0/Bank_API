using Bank_API.DB;
using Bank_API.Models;
using Bank_API.Reposatorys.GenerecReposatory;
using Microsoft.EntityFrameworkCore;

namespace Bank_API.Reposatorys.CustomerReposatory
{
    public class CustometRepo : GenerecRepo<Customer>, ICustomer
    {
        public CustometRepo(AppDbContext context) : base(context)
        {
        }

        public async Task<Customer> GetCustomer(int id)
        {
            return await context.customers.Include(x => x.accounts).Include(x => x.BankCard).FirstOrDefaultAsync(x => x.CustomerId == id);
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await context.customers.Include(x => x.accounts).Include(x => x.BankCard).ToListAsync();
        }
    }
}
