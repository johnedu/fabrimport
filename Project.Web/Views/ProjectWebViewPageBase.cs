using Abp.Dependency;
using Abp.Runtime.Session;
using Abp.Web.Mvc.Views;

namespace Project.Web.Views
{
    public abstract class ProjectWebViewPageBase : ProjectWebViewPageBase<dynamic>
    {
       
    }

    public abstract class ProjectWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        public IAbpSession AbpSession { get; private set; }
        
        protected ProjectWebViewPageBase()
        {
            AbpSession = IocManager.Instance.Resolve<IAbpSession>();
            LocalizationSourceName = ProjectConsts.LocalizationSourceName;
        }
    }
}