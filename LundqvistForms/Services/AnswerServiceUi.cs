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

        public async Task<List<AnswerModel>?> GetAllAnswers(Guid formId)
        {
            var stringContent = JsonSerializer.Serialize(formId);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _clientWrapper.PutAsync<List<AnswerModel>?>($"/Answer/Current", data);
        }
    }
}
