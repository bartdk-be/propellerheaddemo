using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Propellerhead.Data
{
    public class CrmDbContextFactory : IDesignTimeDbContextFactory<CrmDbContext>
    {
        public CrmDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CrmDbContext>();
            var connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Propellerhead.Data.CrmContext.Test.Integration;Integrated Security=SSPI";

            builder.UseSqlServer(connectionString);

            return new CrmDbContext(builder.Options);
        }
    }
}