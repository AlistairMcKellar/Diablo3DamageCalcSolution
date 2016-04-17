using System.Web.Mvc;
using Diablo3DamageCalc.Models;
using D3DataContracts;
using Diablo3DataAccessor;

namespace Diablo3DamageCalc.Controllers
{
    public class HomeController : Controller
    {

        public static ProfileModel playerModel = new ProfileModel();

        public ActionResult Index()
        {
            ViewBag.NoPlayerFound = false;
            return View(playerModel);
        }

        [HttpPost]
        public ActionResult Index(ProfileModel profile)
        {
            if (ModelState.IsValid)
            {

                playerModel.BattleTag = profile.BattleTag;
                playerModel.PlayerProfile = Diablo3ApiCalls.GetPlayerProfile(playerModel.BattleTag);
                if (playerModel.PlayerProfile != null)
                {
                    return RedirectToAction("PlayerProfile");
                }

                ViewBag.NoPlayerFound = true;
            }

            return View(profile);
        }

        public ActionResult PlayerProfile()
        {
            return View(playerModel);
        }

        [HttpPost]
        public ActionResult PlayerProfile(ProfileModel model)
        {
            if (ModelState.IsValid)
            {
                playerModel.SelectedHero = model.SelectedHero;
                playerModel.PlayerProfile.UpdateSelectedHero(model.SelectedHero, Diablo3ApiCalls.GetHeroDetails(playerModel.BattleTag, playerModel.SelectedHero));
                return Redirect("HeroProfile");
            }

            return View(model);
        }

        public ActionResult HeroProfile()
        {
            HeroesModel model = new HeroesModel();
            model.Hero = playerModel.PlayerProfile.GetSelectedHero(playerModel.SelectedHero);
            return View(model);
        }
    }
}
