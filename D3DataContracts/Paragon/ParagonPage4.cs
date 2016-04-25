using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3DataContracts.Paragon
{
    class ParagonPage4 : IParagonPage
    {
        public int ActualMaxPoints { get; private set; }
        public ParagonStat stat1 { get; private set; }
        public ParagonStat stat2 { get; private set; }
        public ParagonStat stat3 { get; private set; }
        public ParagonStat stat4 { get; private set; }

        public string PageName { get; private set; }

        public ParagonPage4(string heroClass, int pageMaxParagonPoints)
        {
            PageName = "Utility Tab";
            ActualMaxPoints = pageMaxParagonPoints;

            if (pageMaxParagonPoints == 200)
            {
                stat1 = new ParagonStat("Area Damage", true, 1.0, 50);
                stat2 = new ParagonStat("Resource Cost Reduction", true, 0.2, 50);
                stat3 = new ParagonStat("Life on Hit", true, 82.5, 50);
                stat4 = new ParagonStat("Gold Find", true, 1.0, 50);

            }
            else
            {
                stat1 = new ParagonStat("Area Damage", true, 1.0);
                stat2 = new ParagonStat("Resource Cost Reduction", true, 0.2);
                stat3 = new ParagonStat("Life on Hit", true, 82.5);
                stat4 = new ParagonStat("Gold Find", true, 1.0);
            }
        }
    }
}
