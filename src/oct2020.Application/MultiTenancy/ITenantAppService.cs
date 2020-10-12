using Abp.Application.Services;
using oct2020.MultiTenancy.Dto;

namespace oct2020.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

