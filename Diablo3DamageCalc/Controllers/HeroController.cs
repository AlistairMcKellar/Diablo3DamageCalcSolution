using System.Web.Mvc;

namespace Diablo3DamageCalc.Controllers
{
    public class HeroController : Controller
    {
        public ActionResult Index(string battleTag, int selectedHero)
        {
            ViewBag.battleTag = battleTag;
            ViewBag.selectedHero = selectedHero;
            return View();
        }
    }
}