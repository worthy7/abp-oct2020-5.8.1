using System.Threading.Tasks;
using oct2020.Configuration.Dto;

namespace oct2020.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
