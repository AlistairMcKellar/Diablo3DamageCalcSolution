using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3DataContracts.Paragon
{
    public class ParagonPoints
    {
        public IParagonPage Page1 { get; private set; }
        public IParagonPage Page2 { get; private set; }
        public IParagonPage Page3 { get; private set; }
        public IParagonPage Page4 { get; private set; }

        public ParagonPoints(string heroClass, int totalParagonPoints)
        {
            int[] pageParagonPoints = GetParagonPointsPerPage(totalParagonPoints);
            Page1 = new ParagonPage1(heroClass, pageParagonPoints[0]);
            Page2 = new ParagonPage2(heroClass, pageParagonPoints[1]);
            Page3 = new ParagonPage3(heroClass, pageParagonPoints[2]);
            Page4 = new ParagonPage4(heroClass, pageParagonPoints[3]); 
        }

        private int[] GetParagonPointsPerPage(int totalParagonPoints)
        {
            if (totalParagonPoints >= 800)
            {
                // as pages 2,3 & 4 can at most have 200 points we know that once we have crossed the 800 mark then all other points must be page 1.
                return new int[] { (totalParagonPoints - 600), 200, 200, 200 };
            }

            int remainder = 0;
            var pointsPer = Math.DivRem(totalParagonPoints, 4, out remainder);

            int[] paragonPointsPerTab;
            switch (remainder)
            {
                case 1:
                    paragonPointsPerTab = new int[] { pointsPer + 1, pointsPer, pointsPer, pointsPer };
                    break;
                case 2:
                    paragonPointsPerTab = new int[] { pointsPer + 1, pointsPer + 1, pointsPer, pointsPer };
                    break;
                case 3:
                    paragonPointsPerTab = new int[] { pointsPer + 1, pointsPer + 1, pointsPer + 1, pointsPer };
                    break;
                default:
                    paragonPointsPerTab = new int[] { pointsPer, pointsPer, pointsPer, pointsPer };
                    break;
            }

            return paragonPointsPerTab;
        }
    }
}
