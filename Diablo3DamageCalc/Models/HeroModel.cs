using D3DataContracts;
using D3DataContracts.Paragon;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diablo3DamageCalc.Models
{
    public class HeroModel
    {
        public string BattleTag { get; private set; }
        public int HeroId { get; private set; }
        public string heroName { get; private set; }

        public string heroClass { get; private set; }

        public IEnumerable<Item> items { get; private set; }

        public Active[] ActiveSkills { get; private set; }
        public Passive[] PassiveSkills { get; private set; }

        public ParagonPoints ParagonPoints { get; private set; }
        public Legendarypower[] legendaryPowers { get; private set; }
        public Stats3 stats { get; private set; }

        public HeroModel(string battleTag, Hero hero)
        {
            BattleTag = battleTag;
            HeroId = hero.id;
            items = hero.items.items;
            ActiveSkills = hero.skills.active;
            PassiveSkills = hero.skills.passive;
            heroName = hero.name;
            heroClass = hero.heroClass;
            stats = hero.stats;
            legendaryPowers = hero.legendaryPowers;

            ParagonPoints = new ParagonPoints(hero.heroClass, hero.paragonLevel);
        }
    }
    
}