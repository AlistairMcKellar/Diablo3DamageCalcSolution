using D3DataContracts;
using D3DataContracts.Deserializer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3DataAccessor
{
    public class Diablo3ApiCalls
    {
        private const string APIKEY = ApiKeys.D3ApiKey;
        private static string urlStart = @"https://eu.api.battle.net/d3/";
        private static string profile = @"profile/";
        private static string heroUrl = @"hero/";
        private static string backSlash = @"/";
        private static string locale = @"?local=en_gb";
        private static string apiKey = @"&apikey=";


        public static PlayerProfile GetPlayerProfile(string battleTag)
        {
            try
            {
                string profileRequest = $"{urlStart}{profile}{battleTag}{backSlash}{locale}{apiKey}{APIKEY}";
                var response = MakeRequest(profileRequest);
                PlayerProfile serializedProfile = JsonDeserialiser.ProfileDeserializer(response);
                return (serializedProfile != null ? serializedProfile : null);
            }
            catch (Exception)
            {
                return null;
            }

        }


        public static Hero GetHeroDetails(string battleTag, int selectedHero)
        {
            try
            {
                string profileRequest = $"{urlStart}{profile}{battleTag}{backSlash}{heroUrl}{selectedHero}{locale}{apiKey}{APIKEY}";
                var response = MakeRequest(profileRequest);
                Hero hero = JsonDeserialiser.HeroDeserializer(response);
                return (hero != null ? hero : null);
            }
            catch (Exception)
            {
                return null;
            }
        }


        private static Stream MakeRequest(string requestUrl)
        {
            var task = MakeRequestAsync(requestUrl);

            task.Wait();

            return task.Result;
        }

        private static async Task<Stream> MakeRequestAsync(string requestUri)
        {
            int tries = 3;

            HttpClient httpClient = new HttpClient();
            var stream = new MemoryStream();

            do
            {
                var response = await httpClient.GetAsync(requestUri).ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                    {
                        responseStream.CopyTo(stream);
                        stream.Position = 0;
                        return stream;
                    }
                }

                Debug.WriteLine("trying again");
                tries--;
            } while (tries > 0);
            return null;

        }
    }
}
