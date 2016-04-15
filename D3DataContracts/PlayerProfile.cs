using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3DataContracts
{
    public class PlayerProfile
    {
        public IList<ProfileHeroDetails> Heroes { get; private set; }

        public PlayerProfile(IList<ProfileHeroDetails> heroes)
        {
            Heroes = heroes;
        }

        public PlayerProfile()
        {
            Heroes = new List<ProfileHeroDetails>();
        }

        public void UpdateSelectedHero(int selectedHero, Hero hero)
        {
            if (Heroes.Any(h => h.Id == selectedHero))
            {
                int index = Heroes.IndexOf(Heroes.SingleOrDefault(h => h.Id == selectedHero));
                Heroes[index].Hero = hero;
            }
        }

        public Hero GetSelectedHero(int selectedHero)
        {
            return  Heroes.SingleOrDefault(h => h.Id == selectedHero).Hero;
        }
    }
}
