using Domain.Interface;
using Domain.Models;
using Newtonsoft.Json;


namespace Data.Repository
{
    public class Repository : IRepository
    {

        private const string ApiListUrl = "https://api.covid19api.com/summary";
        private static HttpClient _httpClient = new HttpClient();
        public Task<Search> GetAsync()
        {
            return GetWeb();
        }

        private async Task<Search> GetWeb()
        {
            using (HttpResponseMessage response = await _httpClient.GetAsync(ApiListUrl))
                if(response.IsSuccessStatusCode)
                {
                    string responseBodyAsText = await  response.Content.ReadAsStringAsync();
                    Search result = JsonConvert.DeserializeObject<Search>(responseBodyAsText);
                    return result;
                }
            return null;
        }
    }
}
