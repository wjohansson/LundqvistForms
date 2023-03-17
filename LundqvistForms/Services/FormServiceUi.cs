using FormsLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using MudBlazor;
using System.Text.Json;
using System.Text;

namespace LundqvistForms.Services
{
    public class FormServiceUi
    {
        private readonly HttpClientWrapper _clientWrapper;

        public FormServiceUi(HttpClientWrapper clientWrapper)
        {
            _clientWrapper = clientWrapper;
        }

        public async Task<int?> CountAnswers(FormModel form)
        {
            var stringContent = JsonSerializer.Serialize(form);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _clientWrapper.PutAsync<int>($"/Form/CountAnswers", data);
        }

        public async Task<FormModel?> CreateForm(FormModel form)
        {
            var stringContent = JsonSerializer.Serialize(form);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _clientWrapper.PostAsync<FormModel>($"/Form/Create", data);
        }

        public async Task DeleteForm(FormModel form)
        {
            var stringContent = JsonSerializer.Serialize(form);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            await _clientWrapper.PutAsync<FormModel>($"/Form/Delete", data);
        }

        public async Task<FormModel?> EditForm(FormModel form)
        {
            var stringContent = JsonSerializer.Serialize(form);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _clientWrapper.PutAsync<FormModel>($"/Form/Edit", data);
        }

        public async Task<List<FormModel>?> GetAllForms()
        {
            return await _clientWrapper.GetAsync<List<FormModel>>($"/Form/All");
        }

        public async Task<FormModel?> GetForm(FormModel form)
        {
            var stringContent = JsonSerializer.Serialize(form);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _clientWrapper.PutAsync<FormModel>($"/Form", data);
        }

        public async Task<FormModel?> GetFormById(Guid formId)
        {
            var stringContent = JsonSerializer.Serialize(formId);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _clientWrapper.PutAsync<FormModel>($"/Form/GetById", data);
        }
    }
}
