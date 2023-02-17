using FormsLibrary.Models;
using System.Text.Json;
using System.Text;

namespace LundqvistForms.Services
{
    public class QuestionServiceUi
    {
        private readonly HttpClientWrapper _clientWrapper;

        public QuestionServiceUi(HttpClientWrapper clientWrapper)
        {
            _clientWrapper = clientWrapper;
        }

        public async Task<QuestionModel?> CreateQuestion(QuestionModel question)
        {
            var stringContent = JsonSerializer.Serialize(question);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _clientWrapper.PostAsync<QuestionModel>($"/Question/Create", data);
        }

        public async Task DeleteQuestion(QuestionModel question)
        {
            var stringContent = JsonSerializer.Serialize(question);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            await _clientWrapper.PutAsync<QuestionModel>($"/Question/Delete", data);
        }

        public async Task<QuestionModel?> EditQuestion(QuestionModel question)
        {
            var stringContent = JsonSerializer.Serialize(question);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _clientWrapper.PutAsync<QuestionModel>($"/Question/Edit", data);
        }

        public async Task<List<QuestionModel>?> GetAllQuestions()
        {
            return await _clientWrapper.GetAsync<List<QuestionModel>>($"/Question/Current");
        }

        public async Task<QuestionModel?> GetQuestion(QuestionModel question)
        {
            var stringContent = JsonSerializer.Serialize(question);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _clientWrapper.PutAsync<QuestionModel>($"/Question", data);
        }
    }
}
