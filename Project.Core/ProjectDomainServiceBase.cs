using Abp.Domain.Services;

namespace Project
{
    public abstract class ProjectDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected ProjectDomainServiceBase()
        {
            LocalizationSourceName = ProjectConsts.LocalizationSourceName;
        }
    }
}
