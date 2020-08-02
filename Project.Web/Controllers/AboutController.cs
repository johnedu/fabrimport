using System.Web.Mvc;

namespace Project.Web.Controllers
{
    public class AboutController : ProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}