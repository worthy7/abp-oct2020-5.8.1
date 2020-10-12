using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using oct2020.MultiTenancy;

namespace oct2020.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
