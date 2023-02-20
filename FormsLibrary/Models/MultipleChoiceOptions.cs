using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FormsLibrary.Models
{
    public class MultipleChoiceOptions
    {
        [Key]
        [JsonPropertyName("multipleChoiceID")]
        public Guid MultipleChoiceId { get; set; } = Guid.NewGuid();

        [JsonPropertyName("multipleChoiceTitle")]
        [Required(ErrorMessage = "Alternativet kan inte vara tomt")]
        public string MultipleChoiceTitle { get; set; } = "";

        [JsonPropertyName("questionId")]
        public Guid QuestionId { get; set; }
    }
}
