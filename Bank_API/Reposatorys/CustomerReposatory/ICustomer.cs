using Bank_API.Models;
using Bank_API.Reposatorys.GenerecReposatory;

namespace Bank_API.Reposatorys.CustomerReposatory
{
    public interface ICustomer : IGenerc<Customer>
    {
        Task<IEnumerable<Customer>> GetCustomers();
        Task<Customer> GetCustomer(int id);
    }
}
