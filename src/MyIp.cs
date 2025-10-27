using System.Net.Http;
using System.Net.Http.Headers;

namespace MyIpApi
{
    public class MyIp
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://api.myip.com";
        public MyIp()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36");
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> GetMyIp()
        {
            var response = await httpClient.GetAsync(apiUrl);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
