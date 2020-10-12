using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using oct2020.Configuration;
using oct2020.Web;

namespace oct2020.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class oct2020DbContextFactory : IDesignTimeDbContextFactory<oct2020DbContext>
    {
        public oct2020DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<oct2020DbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            oct2020DbContextConfigurer.Configure(builder, configuration.GetConnectionString(oct2020Consts.ConnectionStringName));

            return new oct2020DbContext(builder.Options);
        }
    }
}
