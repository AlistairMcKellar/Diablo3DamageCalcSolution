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
        public string BattleTag { get; private set; }
        public IEnumerable<Hero> Heroes { get; private set; }

        public PlayerProfile(string battleTag, IEnumerable<Hero> heroes)
        {
            BattleTag = battleTag;
            Heroes = heroes;
        }
        
    }
}
