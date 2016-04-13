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

                string battleTag = (string)o["battleTag"];

                var heroes = from h in o["heroes"]
                             select new Hero((string)h["name"], (string)h["id"]);

                profile = new PlayerProfile(battleTag, heroes);

            }

            return profile;
        }

    }
}
