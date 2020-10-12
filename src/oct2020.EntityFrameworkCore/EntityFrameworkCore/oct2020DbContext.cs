using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using oct2020.Authorization.Roles;
using oct2020.Authorization.Users;
using oct2020.MultiTenancy;

namespace oct2020.EntityFrameworkCore
{
    public class oct2020DbContext : AbpZeroDbContext<Tenant, Role, User, oct2020DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public oct2020DbContext(DbContextOptions<oct2020DbContext> options)
            : base(options)
        {
        }
    }
}
