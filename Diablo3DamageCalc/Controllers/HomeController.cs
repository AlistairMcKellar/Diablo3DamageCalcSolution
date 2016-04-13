using System.Web.Mvc;
using Diablo3DataAccessor;
using System.IO;
using Diablo3DamageCalc.Models;

namespace Diablo3DamageCalc.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult PlayerProfile()
        {
            var model = new ProfileModel(Diablo3ApiCalls.GetPlayerProfile());

            return View(model);
            //return View();
        }
    }
}