using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using oct2020.Configuration;

namespace oct2020.Web.Host.Startup
{
    [DependsOn(
       typeof(oct2020WebCoreModule))]
    public class oct2020WebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public oct2020WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(oct2020WebHostModule).GetAssembly());
        }
    }
}
