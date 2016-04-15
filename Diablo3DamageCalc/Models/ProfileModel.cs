using D3DataContracts;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace Diablo3DamageCalc.Models
{
    public class ProfileModel
    {
        [Required]
        [DisplayName("BattleTag")]
        [RegularExpression(@"[a-zA-Z]*-[0-9]*$", ErrorMessage = "BattleTag should be of the format name-1234")]
        public string BattleTag { get; set; }

        public PlayerProfile PlayerProfile { get; set; }

        [Display(Name = "Selected Hero")]
        public int SelectedHero { get; set; }

        public IEnumerable<SelectListItem> HeroNames
        {
            get
            {
                var allHeroes = PlayerProfile.Heroes.Select(h => new SelectListItem
                {
                    Value = h.Id.ToString(),
                    Text = h.Name
                });
                return allHeroes;
            }

        }
        public ProfileModel()
        {
            PlayerProfile = new PlayerProfile();
        }

        //Html.DropDownListFor(m => m.chosenPlaylist.PlaylistId, (SelectList)ViewBag.chosenId)).
        //    Html.DropDownListFor( m => m.SelectedHero, Model.HeroNames)

    }
}