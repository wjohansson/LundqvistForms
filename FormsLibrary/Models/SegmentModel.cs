using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
