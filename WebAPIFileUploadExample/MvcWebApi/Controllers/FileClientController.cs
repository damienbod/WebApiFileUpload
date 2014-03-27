using System.Web.Mvc;

namespace MvcWebApi.Controllers
{
    public class FileClientController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Index Page";

            return View();
        }

        public ActionResult Client()
        {
            ViewBag.Title = "Ex Client";

            return View();
        }

        public ActionResult MultiClient()
        {
            ViewBag.Title = "Ex MultiClient";

            return View();
        }
    }
}
