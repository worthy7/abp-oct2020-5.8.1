using Abp.Authorization;
using oct2020.Authorization.Roles;
using oct2020.Authorization.Users;

namespace oct2020.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
