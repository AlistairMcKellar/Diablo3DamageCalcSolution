namespace D3DataContracts.Paragon
{
    public class ParagonStat
    {

        private static int MaxPoints = 50;
        public string Name { get; private set; }
        public int CurrentPoints { get; private set; }
        public bool StatAllocationLimited { get; private set; }
        public double StatIncreasePerPoint { get; private set; }

        public ParagonStat(string name, bool statAllocationLimited, double statIncreasePerPoint)
        {
            Name = name;
            StatAllocationLimited = statAllocationLimited;
            CurrentPoints = 0;
            StatIncreasePerPoint = statIncreasePerPoint;
            CurrentPoints = 0;
        }

        public ParagonStat(string name, bool statAllocationLimited, double statIncreasePerPoint, int currentPoints)
        {
            Name = name;
            StatAllocationLimited = statAllocationLimited;
            CurrentPoints = 0;
            StatIncreasePerPoint = statIncreasePerPoint;
            CurrentPoints = currentPoints;
        }
    }
}