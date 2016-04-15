using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;

namespace D3DataContracts.Deserializer
{
    public static class JsonDeserialiser
    {
        public static PlayerProfile ProfileDeserializer(Stream jsonStream)
        {
            PlayerProfile profile = null;
            using (StreamReader reader = new StreamReader(jsonStream))
            {
                JObject o = (JObject)JToken.ReadFrom(new JsonTextReader(reader));

                //string battleTag = (string)o["battleTag"];

                try
                {
                    var heroes = from h in o["heroes"]
                                 select new ProfileHeroDetails((string)h["name"], (int)h["id"], (string)h["class"], (int)h["level"], (bool)h["seasonal"]);

                    profile = new PlayerProfile(heroes.ToList());
                }
                catch (ArgumentNullException)
                {
                    return null;
                }


            }

            return profile;
        }

        public static Hero HeroDeserializer(Stream response)
        {
            Hero hero;
            using (StreamReader reader = new StreamReader(response))
            {
                string json = reader.ReadToEnd();
                hero = JsonConvert.DeserializeObject<Hero>(json);
            }
            return hero;
        }
    }
}
