using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using oct2020.Configuration.Dto;

namespace oct2020.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : oct2020AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
