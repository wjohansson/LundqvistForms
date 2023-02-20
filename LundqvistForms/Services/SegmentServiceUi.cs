using FormsLibrary.Models;
using System.Text.Json;
using System.Text;

namespace LundqvistForms.Services
{
    public class SegmentServiceUi
    {
        private readonly HttpClientWrapper _clientWrapper;

        public SegmentServiceUi(HttpClientWrapper clientWrapper)
        {
            _clientWrapper = clientWrapper;
        }

        public Task<SegmentModel?> CreateSegment(SegmentModel segment)
        {
            var stringContent = JsonSerializer.Serialize(segment);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _clientWrapper.PostAsync<SegmentModel>($"/Segment/Create", data);
        }

        public async Task DeleteSegment(SegmentModel segment)
        {
            var stringContent = JsonSerializer.Serialize(segment);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            await _clientWrapper.PutAsync<SegmentModel>($"/Segment/Delete", data);
        }

        public async Task<SegmentModel?> EditSegment(SegmentModel segment)
        {
            var stringContent = JsonSerializer.Serialize(segment);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _clientWrapper.PutAsync<SegmentModel>($"/Segment/Edit", data);
        }

        public async Task<List<SegmentModel>?> GetAllSegments()
        {
            return await _clientWrapper.GetAsync<List<SegmentModel>>($"/Segment/Current");
        }

        public async Task<SegmentModel?> GetSegment(SegmentModel segment)
        {
            var stringContent = JsonSerializer.Serialize(segment);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _clientWrapper.PutAsync<SegmentModel>($"/Segment", data);
        }
    }
}
