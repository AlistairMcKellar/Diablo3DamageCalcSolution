namespace D3DataContracts
{
    public class ProfileHeroDetails
    {
        public string Name { get; private set; }
        public int Id { get; private set; }
        public string HeroClass { get; private set; }
        public int Level { get; private set; }
        public bool Seasonal { get; private set; }
        public Hero Hero { get; set; }


        public ProfileHeroDetails(string name, int id, string heroClass, int level, bool seasonal)
        {
            Name = name;
            HeroClass = heroClass;
            Id = id;
            Level = level;
            Seasonal = seasonal;
        }

        public override string ToString()
        {
            string seasonal = Seasonal ? "S:" : string.Empty;
            return $"{seasonal}{Name} - {HeroClass} - lvl {Level}";
        }

        public override bool Equals(object obj)
        {
            
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}