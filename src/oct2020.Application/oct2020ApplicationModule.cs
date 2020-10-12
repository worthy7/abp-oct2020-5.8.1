using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using oct2020.Authorization;

namespace oct2020
{
    [DependsOn(
        typeof(oct2020CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class oct2020ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<oct2020AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(oct2020ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
