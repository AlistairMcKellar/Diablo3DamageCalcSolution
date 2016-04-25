using System;

namespace D3DataContracts.Paragon
{
    public class ParagonPage2 : IParagonPage
    {
        public int ActualMaxPoints { get; private set;}
        public ParagonStat stat1 { get; private set; }
        public ParagonStat stat2 { get; private set; }
        public ParagonStat stat3 { get; private set; }
        public ParagonStat stat4 { get; private set; }

        public string PageName { get; private set; }

        public ParagonPage2(string heroClass, int pageMaxParagonPoints)
        {
            PageName = "Offense Tab";
            ActualMaxPoints = pageMaxParagonPoints;
            if (pageMaxParagonPoints == 200)
            {
                stat1 = new ParagonStat("Attack Speed", true, 0.2, 50);
                stat2 = new ParagonStat("Cooldown Reduction", true, 2.0, 50);
                stat3 = new ParagonStat("Crit Hit Chance", true, 0.1, 50);
                stat4 = new ParagonStat("Cirt Hit Damange", true, 1.0, 50);

            }
            else
            {
                stat1 = new ParagonStat("Attack Speed", true, 0.2);
                stat2 = new ParagonStat("Cooldown Reduction", true, 2.0);
                stat3 = new ParagonStat("Crit Hit Chance", true, 0.1);
                stat4 = new ParagonStat("Cirt Hit Damange", true, 1.0);

            }
        }
    }
}