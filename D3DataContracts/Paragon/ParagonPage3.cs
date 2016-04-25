using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3DataContracts.Paragon
{
    public class ParagonPage3 : IParagonPage
    {
        public int ActualMaxPoints { get; private set; }
        public ParagonStat stat1 { get; private set; }
        public ParagonStat stat2 { get; private set; }
        public ParagonStat stat3 { get; private set; }
        public ParagonStat stat4 { get; private set; }

        public string PageName { get; private set; }

        public ParagonPage3(string heroClass, int pageMaxParagonPoints)
        {
            PageName = "Defense Tab";
            ActualMaxPoints = pageMaxParagonPoints;

            if (pageMaxParagonPoints == 200)
            {
                stat1 = new ParagonStat("Life", true, 0.5, 50);
                stat2 = new ParagonStat("Armor", true, 0.5, 50);
                stat3 = new ParagonStat("All Resist", true, 5.0, 50);
                stat4 = new ParagonStat("Life Regen", true, 165.1, 50);
            }
            else
            {
                stat1 = new ParagonStat("Life", true, 0.5);
                stat2 = new ParagonStat("Armor", true, 0.5);
                stat3 = new ParagonStat("All Resist", true, 5.0);
                stat4 = new ParagonStat("Life Regen", true, 165.1);

            }
        }
    }
}
