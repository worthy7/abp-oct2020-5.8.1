using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace oct2020.Controllers
{
    public abstract class oct2020ControllerBase: AbpController
    {
        protected oct2020ControllerBase()
        {
            LocalizationSourceName = oct2020Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
