using Diablo3DamageCalc.Models;
using Diablo3DataAccessor;
using System.Web.Mvc;

namespace Diablo3DamageCalc.Controllers
{
    public class HeroProfileController : Controller
    {
        // GET: HeroProfile
        public ActionResult Index(string battleTag, int selectedHero)
        {
            var model = new HeroModel(battleTag, Diablo3ApiCalls.GetHeroDetails(battleTag, selectedHero));
            //var model = new HeroModel("davnel-2383", Diablo3ApiCalls.GetHeroDetails("davnel-2383", 38843));

            return Json(model, JsonRequestBehavior.AllowGet);
        }

    }
}