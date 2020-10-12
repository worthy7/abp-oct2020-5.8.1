using System.Threading.Tasks;
using Abp.Application.Services;
using oct2020.Authorization.Accounts.Dto;

namespace oct2020.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
