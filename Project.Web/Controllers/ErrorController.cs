using System.Web.Mvc;
using Abp.Auditing;

namespace Project.Web.Controllers
{
    public class ErrorController : ProjectControllerBase
    {
        [DisableAuditing]
        public ActionResult E404()
        {
            return View();
        }
    }
}