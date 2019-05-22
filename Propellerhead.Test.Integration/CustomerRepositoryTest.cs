using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Propellerhead.Data;
using Propellerhead.Data.Model;

namespace Propellerhead.Test.Integration
{
    [TestClass]
    public class CustomerRepositoryTest : RepositoryTestBase
    {
        [TestMethod]
        public async Task GivenNewCustomer_WhenAdd_ShouldStoreCustomer()
        {
            var repository = new CustomerRepository(Context);
            var customer = new Customer();

            repository.Insert(customer);
            await repository.SaveChangesAsync();
            var savedCustomer = await repository.GetAsync(customer.Id);

            Assert.IsNotNull(savedCustomer);
        }
    }
}
