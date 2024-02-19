using MVCFrameworkApp.Models;
using System.Web.Mvc;

namespace MVCFrameworkApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var model = new AboutModel();
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page";
            return View();
        }
    }
}