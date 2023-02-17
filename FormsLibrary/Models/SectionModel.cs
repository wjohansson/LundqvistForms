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
    public class SectionModel
    {
        [Key]
        [JsonPropertyName("sectionId")]
        public Guid SectionId { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Avsnittet måste ha en rubrik")]
        [JsonPropertyName("sectionTitle")]
        public string SectionTitle { get; set; } = "";

        [Required(ErrorMessage = "Avsnittet måste ha en beskrivning")]
        [JsonPropertyName("sectionDescription")]
        public string SectionDescription { get; set; } = "";

        [JsonPropertyName("formId")]
        public Guid FormId { get; set; }

        [ForeignKey("SectionId")]
        [JsonPropertyName("questions")]
        public ICollection<QuestionModel> Questions { get; set; }

        public SectionModel()
        {
            Questions = new List<QuestionModel>();
        }
    }
}
