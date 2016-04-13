namespace D3DataContracts
{
    public class Hero
    {
        public string Name { get; private set; }
        public int Id { get; private set; }

        public Hero(string name, string id)
        {
            Name = name;
            int i;
            if (int.TryParse(id, out i))
            {
                Id = i;
            }
        }
    }
}