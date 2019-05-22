using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Propellerhead.Data.Model;

namespace Propellerhead.Data
{
    public interface ICustomerRepository
    {
        void Insert(Customer customer);
        Task SaveChangesAsync();
        Task<Customer> GetAsync(Guid id);
        Task<List<Customer>> GetAll();
        void Update(Customer customer);
        bool Any(Guid id);
        Task Remove(Guid id);
    }
}