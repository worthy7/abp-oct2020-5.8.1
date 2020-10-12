using System.Threading.Tasks;
using Abp.Application.Services;
using oct2020.Sessions.Dto;

namespace oct2020.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
