using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AuditorDLL
{
    public class Goblin
    {
        public VexAdmin VA = new VexAdmin();
        private string APIROOTPATH { get; set; } = @"https://www.bungie.net/Platform";
        private static string KEY { get; set; } = "X-API-KEY";
        private static string APIKEY { get; set; } = ""; // Not shared, must provide own for use of code. Otherwise see published app for functionality.
        public DataLattice DL = new DataLattice();

        /// <summary>
        /// Async Task to return Http GET API call
        /// </summary>
        /// <param name="uri">API URI</param>
        /// <returns>HttpContent returned by API</returns>
        public async static Task<HttpContent> GetRequestTask(string uri)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(KEY, APIKEY);
                using (HttpResponseMessage response = await client.GetAsync(uri))
                {
                    using (HttpContent content = response.Content)
                    {
                        return content;
                    }
                }
            }
        }

        /// <summary>
        /// Async Task to perform an Http POST API call
        /// </summary>
        /// <param name="uri">API URI</param>
        /// <param name="SC">HttpContent containing parameters, null if none</param>
        /// <returns>HttpContent returned by API</returns>
        public async static Task<HttpContent> PostRequest(string uri, HttpContent SC)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(KEY, APIKEY);
                using (HttpResponseMessage response = await client.PostAsync(uri, SC))
                {
                    using (HttpContent content = response.Content)
                    {
                        return content;
                    }
                }
            }
        }


    }
}
