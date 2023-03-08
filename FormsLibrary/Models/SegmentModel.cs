using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FormsLibrary.Models
{
    public class SegmentModel
    {
        [Key]
        [JsonPropertyName("segmentId")]
        public Guid SegmentId { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Avsnittet måste ha en rubrik")]
        [JsonPropertyName("segmentTitle")]
        public string SegmentTitle { get; set; } = "";

        [Required(ErrorMessage = "Avsnittet måste ha en beskrivning")]
        [JsonPropertyName("segmentDescription")]
        public string SegmentDescription { get; set; } = "";

        [JsonPropertyName("segmentOrder")]
        public int SegmentOrder { get; set; }

        [JsonPropertyName("segmentDate")]
        public DateTime SegmentDate { get; set; }

        [JsonPropertyName("formId")]
        public Guid FormId { get; set; }

        [ForeignKey("SegmentId")]
        [JsonPropertyName("questions")]
        public ICollection<QuestionModel> Questions { get; set; }

        public SegmentModel()
        {
            Questions = new List<QuestionModel>();
        }
    }
}
