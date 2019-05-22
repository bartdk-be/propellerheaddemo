﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Propellerhead.Data.Model;

namespace Propellerhead.Data
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CrmDbContext _context;

        public CustomerRepository(CrmDbContext context)
        {
            _context = context;
        }

        public void Insert(Customer customer)
        {
            customer.Id = Guid.NewGuid();
            customer.CreationDate = DateTime.UtcNow;
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

        public async Task<List<Customer>> GetAll()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task Update(Customer customer)
        {
            var storeCustomer = await GetAsync(customer.Id);
            storeCustomer.CustomerStatus = customer.CustomerStatus;

            _context.Customers.Update(storeCustomer);
        }

        public bool Any(Guid id)
        {
            return _context.Customers.Any(x => x.Id == id);
        }

        public async Task Remove(Guid id)
        {
            var customer = await GetAsync(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
            }            
        }
    }
}