using Microsoft.EntityFrameworkCore;
using Propellerhead.Data.Model;

namespace Propellerhead.Data
{
    public class CrmDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }        
                

        public CrmDbContext(DbContextOptions<CrmDbContext> options) :base(options)
        {            
        }
    }
}
