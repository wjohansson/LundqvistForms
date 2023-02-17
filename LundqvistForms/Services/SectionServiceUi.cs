using FormsLibrary.Models;
using System.Text.Json;
using System.Text;

namespace LundqvistForms.Services
{
    public class SectionServiceUi
    {
        private readonly HttpClientWrapper _clientWrapper;

        public SectionServiceUi(HttpClientWrapper clientWrapper)
        {
            _clientWrapper = clientWrapper;
        }

        public async Task<SectionModel?> CreateSection(SectionModel section)
        {
            var stringContent = JsonSerializer.Serialize(section);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _clientWrapper.PostAsync<SectionModel>($"/Section/Create", data);
        }

        public async Task DeleteSection(SectionModel section)
        {
            var stringContent = JsonSerializer.Serialize(section);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            await _clientWrapper.PutAsync<SectionModel>($"/Section/Delete", data);
        }

        public async Task<SectionModel?> EditSection(SectionModel section)
        {
            var stringContent = JsonSerializer.Serialize(section);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _clientWrapper.PutAsync<SectionModel>($"/Section/Edit", data);
        }

        public async Task<List<SectionModel>?> GetAllSections()
        {
            return await _clientWrapper.GetAsync<List<SectionModel>>($"/Section/Current");
        }

        public async Task<SectionModel?> GetSection(SectionModel section)
        {
            var stringContent = JsonSerializer.Serialize(section);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _clientWrapper.PutAsync<SectionModel>($"/Section", data);
        }
    }
}
