using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace oct2020.EntityFrameworkCore
{
    public static class oct2020DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<oct2020DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<oct2020DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
