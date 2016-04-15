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
        public IEnumerable<Hero> Heroes { get; private set; }

        public PlayerProfile(IEnumerable<Hero> heroes)
        {
            Heroes = heroes;
        }

        public PlayerProfile()
        {
            Heroes = new List<Hero>();
        }

        public void AddHeroesToProfile(IEnumerable<Hero> heroes)
        {
            Heroes = heroes;
        }
    }
}
