using System.Net;
using System.Text.Json;

namespace LundqvistForms.Services
{
    public class HttpClientWrapper
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "https://localhost:5000/api";

        public HttpClientWrapper(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<T?> GetAsync<T>(string url)
        {
            var response = await _httpClient.GetAsync(_baseUrl + url);
            response.EnsureSuccessStatusCode();

            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<T>(responseContent);
        }

        public async Task<T?> PutAsync<T>(string url, HttpContent content)
        {
            var response = await _httpClient.PutAsync(_baseUrl + url, content);
            response.EnsureSuccessStatusCode();

            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<T>(responseContent);
        }

        public async Task<T?> PostAsync<T>(string url, HttpContent content)
        {
            var response = await _httpClient.PostAsync(_baseUrl + url, content);

            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new Exception();
            }

            response.EnsureSuccessStatusCode();

            using var responseContent = response.Content.ReadAsStreamAsync().Result;
            return await JsonSerializer.DeserializeAsync<T>(responseContent);
        }

        public async Task<T?> DeleteAsync<T>(string url)
        {
            var response = await _httpClient.DeleteAsync(_baseUrl + url);
            response.EnsureSuccessStatusCode();

            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<T>(responseContent);
        }
    }
}
