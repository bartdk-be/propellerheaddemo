using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Propellerhead.Data;
using Propellerhead.Data.Model;

namespace Propellerhead.Test.Unit
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        private CrmDbContext _dbContext;
        private CustomerRepository _repository;

        [TestInitialize]
        public void OnTestInitialize()
        {
            var options = new DbContextOptionsBuilder<CrmDbContext>()
                .UseInMemoryDatabase("crmdbcontext_" + Guid.NewGuid())
                .Options;

            _dbContext = new CrmDbContext(options);
            _repository = new CustomerRepository(_dbContext);
        }

        [TestMethod]
        public async Task GivenNewCustomer_WhenInsert_ShouldGetCreationTimeStamp()
        {
            var customer = new Customer();
            _repository.Insert(customer);
            await _repository.SaveChangesAsync();
            var savedCustomer = await _repository.GetAsync(customer.Id);

            Assert.AreEqual(DateTime.UtcNow.Date, savedCustomer.CreationDate.Date);
        }
    }
}
