using Bank_API.DTO.Cusutomers;
using Bank_API.Models;
using Bank_API.Reposatorys.CustomerReposatory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bank_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomer _customer;

        public CustomerController(ICustomer customer)
        {
            _customer = customer;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _customer.GetCustomers();
            var result = customers.Select(x => new GetCustomers
            {
                Email = x.Email,
                Name = x.Name,
                PhonNumber = x.PhonNumber,
                BankCard = x.BankCard == null ? null : new GetCustomersWithBanckCard
                {
                    CardNumber = x.BankCard.CardNumber,
                    ExpiryDate = x.BankCard.ExpiryDate,
                },
                accounts = x.accounts?.Select(a => new GetCustomersWithAccount
                {
                    AccountNumber = a.AccountNumber,
                    Balance = a.Balance
                }).ToList()
            }).ToList();
            return Ok(result);
        }

        [HttpGet("Id ")]
        public async Task<IActionResult> GetById(int id)
        {
            var customers = await _customer.GetCustomer(id);
            if (customers == null)
            {
                return NotFound();
            }

            var custo = new GetCustomers
            {
                Name = customers.Name,
                Email = customers.Email,
                PhonNumber = customers.PhonNumber,
                BankCard = customers.BankCard == null ? null : new GetCustomersWithBanckCard
                {
                    CardNumber = customers.BankCard.CardNumber,
                    ExpiryDate = customers.BankCard.ExpiryDate
                },
                accounts = customers.accounts.Select(x => new GetCustomersWithAccount
                {
                    AccountNumber = x.AccountNumber,
                    Balance = x.Balance
                }).ToList()

            };
            return Ok(custo);
        }
    }


}
