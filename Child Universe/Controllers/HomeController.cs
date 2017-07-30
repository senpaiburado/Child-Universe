using Child_Universe.Models;
using System.Web.Mvc;

namespace Child_Universe.Controllers
{
    public class HomeController : Controller
    {
        Context Context = new Context();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}