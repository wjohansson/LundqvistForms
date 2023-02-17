using FormsLibrary.Models;
using System.Text.Json;
using System.Text;

namespace LundqvistForms.Services
{
    public class AnswerServiceUi
    {
        private readonly HttpClientWrapper _clientWrapper;

        public AnswerServiceUi(HttpClientWrapper clientWrapper)
        {
            _clientWrapper = clientWrapper;
        }

        public async Task<AnswerModel?> CreateAnswer(AnswerModel answer)
        {
            var stringContent = JsonSerializer.Serialize(answer);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _clientWrapper.PostAsync<AnswerModel>($"/Answer/Create", data);
        }

        public async Task DeleteAnswer(AnswerModel answer)
        {
            var stringContent = JsonSerializer.Serialize(answer);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            await _clientWrapper.PutAsync<AnswerModel>($"/Answer/Delete", data);
        }

        public async Task<AnswerModel?> EditAnswer(AnswerModel answer)
        {
            var stringContent = JsonSerializer.Serialize(answer);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _clientWrapper.PutAsync<AnswerModel>($"/Answer/Edit", data);
        }

        public async Task<List<AnswerModel>?> GetAllAnswers()
        {
            return await _clientWrapper.GetAsync<List<AnswerModel>>($"/Answer/Current");
        }

        public async Task<AnswerModel?> GetAnswer(AnswerModel answer)
        {
            var stringContent = JsonSerializer.Serialize(answer);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _clientWrapper.PutAsync<AnswerModel>($"/Answer", data);
        }
    }
}
