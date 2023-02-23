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
    public class MultipleChoiceAnswerModel
    {
        [Key]
        [JsonPropertyName("multipleChoiceId")]
        public Guid MultipleChoiceId { get; set; } = Guid.NewGuid();

        [JsonPropertyName("multipleChoiceTitle")]
        public string? MultipleChoiceTitle { get; set; }

        [JsonPropertyName("answerId")]
        public Guid AnswerId { get; set; }
    }
}
