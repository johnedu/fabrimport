using Abp.WebApi.Controllers;

namespace Project.WebApi
{
    public abstract class ProjectApiControllerBase : AbpApiController
    {
        protected ProjectApiControllerBase()
        {
            LocalizationSourceName = ProjectConsts.LocalizationSourceName;
        }
    }
}