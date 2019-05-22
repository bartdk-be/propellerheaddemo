using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Propellerhead.Data;

namespace Propellerhead.Web
{
    public static class WebHostExtensions
    {
        public static IWebHost Seed(this IWebHost webhost)
        {
            using (var scope = webhost.Services.GetService<IServiceScopeFactory>().CreateScope())
            using (var context = scope.ServiceProvider.GetRequiredService<CrmDbContext>())
            {
                context.Database.Migrate();
            }

            return webhost;
        }
    }
}