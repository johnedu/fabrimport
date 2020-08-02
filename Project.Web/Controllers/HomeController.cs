using System.Web.Mvc;

namespace Project.Web.Controllers
{
    public class HomeController : ProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}