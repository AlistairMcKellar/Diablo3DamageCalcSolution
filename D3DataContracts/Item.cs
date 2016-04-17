using Newtonsoft.Json;

namespace D3DataContracts
{
    public class Item
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
        public string[] setItemsEquipped { get; set; }

    }



    public class Head : Item
    {
    }

    public class Torso : Item
    {
    }

    public class Feet : Item
    {
    }

    public class Hands : Item
    {
    }

    public class Shoulders : Item
    {
    }

    public class Legs : Item
    {
    }

    public class Bracers : Item
    {
    }

    public class Mainhand : Item
    {
    }

    public class Offhand : Item
    {
    }

    public class Waist : Item
    {
    }

    public class Rightfinger : Item
    {
    }

    public class Leftfinger : Item
    {
    }

    public class Neck : Item
    {
    }

}