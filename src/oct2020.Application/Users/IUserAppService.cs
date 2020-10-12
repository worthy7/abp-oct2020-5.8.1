using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using oct2020.Roles.Dto;
using oct2020.Users.Dto;

namespace oct2020.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
