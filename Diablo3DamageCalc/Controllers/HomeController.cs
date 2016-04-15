using System.Web.Mvc;
using Diablo3DamageCalc.Models;
using D3DataContracts;
using Diablo3DataAccessor;

namespace Diablo3DamageCalc.Controllers
{
    public class HomeController : Controller
    {

        public static ProfileModel playerModel = new ProfileModel();
        public static HeroesModel heroesModel = new HeroesModel();

        public ActionResult Index()
        {
            return View(playerModel);
        }

        [HttpPost]
        public ActionResult Index(ProfileModel profile)
        {
            if (ModelState.IsValid)
            {

                playerModel.BattleTag = profile.BattleTag;
                return RedirectToAction("PlayerProfile");
            }

            return View(profile);
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
            playerModel.PlayerProfile = Diablo3ApiCalls.GetPlayerProfile(playerModel.BattleTag);

            heroesModel.PlayerProfile = playerModel.PlayerProfile;

            ViewBag.PlayerName = playerModel.BattleTag;

            return View(heroesModel);
        }

        [HttpPost]
        public ActionResult PlayerProfile(ProfileModel model)
        {
            if (ModelState.IsValid)
            {

            }

            return View(model);
        }

        public ActionResult HeroProfile()
        {
            return View();
        }
    }
}
