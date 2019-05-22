using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Propellerhead.Data.Model;

namespace Propellerhead.Data
{
    public class CustomerRepository
    {
        private readonly CrmDbContext _context;

        public CustomerRepository(CrmDbContext context)
        {
            _context = context;
        }

        public void Insert(Customer customer)
        {
            _context.Customers.Add(customer);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<Customer> GetAsync(Guid id)
        {
            return await _context.Customers.SingleOrDefaultAsync(x => x.Id == id);
        }
    }
}