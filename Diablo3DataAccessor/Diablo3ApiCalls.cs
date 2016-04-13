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
        #region APIKEY
        private const string APIKEY = "ehug4yduftqymcjm4wxfvupyptrev6q9";
        #endregion
        // private const string APIKEY = <yourkeyhere>;
        private static string battleTag = @"Davnel-2383";
        private static string heroId = @"38843";
        private static string urlStart = @"https://eu.api.battle.net/d3/";
        private static string profile = @"profile/";
        private static string hero = @"hero/";
        private static string backSlash = @"/";
        private static string locale = @"?local=en_gb";
        private static string apiKey = @"&apikey=";


        public static PlayerProfile GetPlayerProfile()
        {

            try
            {
                string profileRequest = $"{urlStart}{profile}{battleTag}{backSlash}{locale}{apiKey}{APIKEY}";
                var response = MakeRequest(profileRequest);
                return JsonDeserialiser.ProfileDeserializer(response);
            }
            catch (Exception)
            {

                return null;
            }

        }

        public static Stream MakeRequest(string requestUrl)
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
