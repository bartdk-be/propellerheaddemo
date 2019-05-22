using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Propellerhead.Data;

namespace Propellerhead.Test.Integration
{
    public class RepositoryTestBase
    {
        protected CrmDbContext Context { get; set; }

        [TestInitialize]
        public void OnInitialize()
        {
            var optionsBuilder = new DbContextOptionsBuilder<CrmDbContext>()
                .UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=Propellerhead.Data.CrmContext.Test.Integration;Integrated Security=SSPI");
        
            Context = new CrmDbContext(optionsBuilder.Options);
            Context.Database.Migrate();
            Transaction = Context.Database.BeginTransaction();
        }

        public IDbContextTransaction Transaction { get; set; }

        [TestCleanup]
        public void OnCleanup()
        {
            Transaction.Rollback();
            Transaction.Dispose();
            Transaction = null;

            Context.Dispose();
            Context = null;
        }
    }
}