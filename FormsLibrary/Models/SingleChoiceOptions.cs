using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FormsLibrary.Models
{
    public class SingleChoiceOptions
    {
        [Key]
        [JsonPropertyName("singleChoiceID")]
        public Guid SingleChoiceId { get; set; } = Guid.NewGuid();

        [JsonPropertyName("multipleChoiceTitle")]
        [Required(ErrorMessage = "Alternativet kan inte vara tomt")]
        public string SingleChoiceTitle { get; set; } = "";

        [JsonPropertyName("questionId")]
        public Guid QuestionId { get; set; }
    }
}
