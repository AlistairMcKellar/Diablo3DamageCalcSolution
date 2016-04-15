using Newtonsoft.Json;

namespace D3DataContracts
{

    public class Hero
    {
        public int id { get; set; }
        public string name { get; set; }
        [JsonProperty("class")]
        public string heroClass { get; set; }
        public int gender { get; set; }
        public int level { get; set; }
        public Kills kills { get; set; }
        public int paragonLevel { get; set; }
        public bool hardcore { get; set; }
        public bool seasonal { get; set; }
        public int seasonCreated { get; set; }
        public Skills skills { get; set; }
        public Items items { get; set; }
        public Followers followers { get; set; }
        public Legendarypower[] legendaryPowers { get; set; }
        public Stats3 stats { get; set; }
        public Progression progression { get; set; }
        public bool dead { get; set; }
        public int lastupdated { get; set; }
    }

    public class Kills
    {
        public int elites { get; set; }
    }

    public class Skills
    {
        public Active[] active { get; set; }
        public Passive[] passive { get; set; }
    }

    public class Active
    {
        public Skill skill { get; set; }
        public Rune rune { get; set; }
    }

    public class Skill
    {
        public string slug { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int level { get; set; }
        public string categorySlug { get; set; }
        public string tooltipUrl { get; set; }
        public string description { get; set; }
        public string simpleDescription { get; set; }
        public string skillCalcId { get; set; }
    }

    public class Rune
    {
        public string slug { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public int level { get; set; }
        public string description { get; set; }
        public string simpleDescription { get; set; }
        public string tooltipParams { get; set; }
        public string skillCalcId { get; set; }
        public int order { get; set; }
    }

    public class Passive
    {
        public Skill1 skill { get; set; }
    }

    public class Skill1
    {
        public string slug { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int level { get; set; }
        public string tooltipUrl { get; set; }
        public string description { get; set; }
        public string flavor { get; set; }
        public string skillCalcId { get; set; }
    }

    public class Items
    {
        public Head head { get; set; }
        public Torso torso { get; set; }
        public Feet feet { get; set; }
        public Hands hands { get; set; }
        public Shoulders shoulders { get; set; }
        public Legs legs { get; set; }
        public Bracers bracers { get; set; }
        public Mainhand mainHand { get; set; }
        public Offhand offHand { get; set; }
        public Waist waist { get; set; }
        public Rightfinger rightFinger { get; set; }
        public Leftfinger leftFinger { get; set; }
        public Neck neck { get; set; }
    }

    public class Head
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
        public string[] setItemsEquipped { get; set; }
    }

    public class Torso
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
        public string[] setItemsEquipped { get; set; }
    }

    public class Feet
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
        public string[] setItemsEquipped { get; set; }
    }

    public class Hands
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
        public string[] setItemsEquipped { get; set; }
    }

    public class Shoulders
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
        public string[] setItemsEquipped { get; set; }
    }

    public class Legs
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
        public string[] setItemsEquipped { get; set; }
    }

    public class Bracers
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class Mainhand
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class Offhand
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class Waist
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class Rightfinger
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
        public string[] setItemsEquipped { get; set; }
    }

    public class Leftfinger
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
        public string[] setItemsEquipped { get; set; }
    }

    public class Neck
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class Followers
    {
        public Templar templar { get; set; }
        public Scoundrel scoundrel { get; set; }
        public Enchantress enchantress { get; set; }
    }

    public class Templar
    {
        public string slug { get; set; }
        public int level { get; set; }
        public Items1 items { get; set; }
        public Stats stats { get; set; }
        public Skill2[] skills { get; set; }
    }

    public class Items1
    {
        public Mainhand1 mainHand { get; set; }
        public Offhand1 offHand { get; set; }
        public Leftfinger1 leftFinger { get; set; }
    }

    public class Mainhand1
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class Offhand1
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class Leftfinger1
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class Stats
    {
        public int goldFind { get; set; }
        public int magicFind { get; set; }
        public int experienceBonus { get; set; }
    }

    public class Skill2
    {
    }

    public class Scoundrel
    {
        public string slug { get; set; }
        public int level { get; set; }
        public Items2 items { get; set; }
        public Stats1 stats { get; set; }
        public Skill3[] skills { get; set; }
    }

    public class Items2
    {
        public Special special { get; set; }
        public Mainhand2 mainHand { get; set; }
        public Rightfinger1 rightFinger { get; set; }
        public Leftfinger2 leftFinger { get; set; }
        public Neck1 neck { get; set; }
    }

    public class Special
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class Mainhand2
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class Rightfinger1
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
        public string[] setItemsEquipped { get; set; }
    }

    public class Leftfinger2
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class Neck1
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class Stats1
    {
        public int goldFind { get; set; }
        public int magicFind { get; set; }
        public int experienceBonus { get; set; }
    }

    public class Skill3
    {
        public Skill4 skill { get; set; }
    }

    public class Skill4
    {
        public string slug { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int level { get; set; }
        public string tooltipUrl { get; set; }
        public string description { get; set; }
        public string simpleDescription { get; set; }
        public string skillCalcId { get; set; }
    }

    public class Enchantress
    {
        public string slug { get; set; }
        public int level { get; set; }
        public Items3 items { get; set; }
        public Stats2 stats { get; set; }
        public Skill5[] skills { get; set; }
    }

    public class Items3
    {
        public Mainhand3 mainHand { get; set; }
        public Leftfinger3 leftFinger { get; set; }
    }

    public class Mainhand3
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class Leftfinger3
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

    public class Stats2
    {
        public int goldFind { get; set; }
        public int magicFind { get; set; }
        public int experienceBonus { get; set; }
    }

    public class Skill5
    {
    }

    public class Stats3
    {
        public int life { get; set; }
        public float damage { get; set; }
        public float toughness { get; set; }
        public float healing { get; set; }
        public float attackSpeed { get; set; }
        public int armor { get; set; }
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int vitality { get; set; }
        public int intelligence { get; set; }
        public int physicalResist { get; set; }
        public int fireResist { get; set; }
        public int coldResist { get; set; }
        public int lightningResist { get; set; }
        public int poisonResist { get; set; }
        public int arcaneResist { get; set; }
        public float critDamage { get; set; }
        public float blockChance { get; set; }
        public int blockAmountMin { get; set; }
        public int blockAmountMax { get; set; }
        public float damageIncrease { get; set; }
        public float critChance { get; set; }
        public float damageReduction { get; set; }
        public float thorns { get; set; }
        public float lifeSteal { get; set; }
        public float lifePerKill { get; set; }
        public float goldFind { get; set; }
        public float magicFind { get; set; }
        public float lifeOnHit { get; set; }
        public int primaryResource { get; set; }
        public int secondaryResource { get; set; }
    }

    public class Progression
    {
        public Act1 act1 { get; set; }
        public Act2 act2 { get; set; }
        public Act3 act3 { get; set; }
        public Act4 act4 { get; set; }
        public Act5 act5 { get; set; }
    }

    public class Act1
    {
        public bool completed { get; set; }
        public object[] completedQuests { get; set; }
    }

    public class Act2
    {
        public bool completed { get; set; }
        public object[] completedQuests { get; set; }
    }

    public class Act3
    {
        public bool completed { get; set; }
        public object[] completedQuests { get; set; }
    }

    public class Act4
    {
        public bool completed { get; set; }
        public object[] completedQuests { get; set; }
    }

    public class Act5
    {
        public bool completed { get; set; }
        public object[] completedQuests { get; set; }
    }

    public class Legendarypower
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
    }

}
