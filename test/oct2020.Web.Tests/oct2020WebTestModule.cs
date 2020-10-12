using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using oct2020.EntityFrameworkCore;
using oct2020.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace oct2020.Web.Tests
{
    [DependsOn(
        typeof(oct2020WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class oct2020WebTestModule : AbpModule
    {
        public oct2020WebTestModule(oct2020EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(oct2020WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(oct2020WebMvcModule).Assembly);
        }
    }
}