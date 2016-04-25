using System;

namespace D3DataContracts.Paragon
{
    public class ParagonPage1 : IParagonPage
    {
        public int ActualMaxPoints { get; private set;}
        public ParagonStat stat1 { get; private set; }
        public ParagonStat stat2 { get; private set; }
        public ParagonStat stat3 { get; private set; }
        public ParagonStat stat4 { get; private set; }

        public string PageName { get; private set; }

        public ParagonPage1(string heroClass, int pageMaxParagonPoints)
        {
            PageName = "Core Tab";
            stat1 = new ParagonStat("Primary Stat", false, 5.00);
            stat2 = new ParagonStat("Vitality", false, 5.00);
            stat3 = new ParagonStat("Movement Speed", true, 0.5);

            double statIncreasePerPoint = 0.00;
            switch (heroClass.ToLower())
            {
                case "demon hunter":
                    statIncreasePerPoint = 0.5;
                    break;
                case "witch doctor":
                    statIncreasePerPoint = 4;
                    break;
                default:
                    // Barb, crusader, monk, wizard
                    statIncreasePerPoint = 1;
                    break;

            }
            stat4 = new ParagonStat("Max Resource", true, statIncreasePerPoint);
            ActualMaxPoints = pageMaxParagonPoints;
        }
    }
}