using D3DataContracts;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Diablo3DamageCalc.Models
{
    public class ProfileModel
    {
        [Required]
        [DisplayName("BattleTag")]
        [RegularExpression(@"[a-zA-Z]*-[0-9]*$", ErrorMessage = "BattleTag should be of the format name-1234")]
        public string BattleTag { get; set; }

        public PlayerProfile PlayerProfile { get; set; }

        public ProfileModel()
        {
            PlayerProfile = new PlayerProfile();
        }

        //Html.DropDownListFor(m => m.chosenPlaylist.PlaylistId, (SelectList)ViewBag.chosenId)).
        //    Html.DropDownListFor( m => m.SelectedHero, Model.HeroNames)

    }
}