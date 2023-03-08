using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FormsLibrary.Models
{
    public class ChoiceModel
    {
        [Key]
        [JsonPropertyName("choiceID")]
        public Guid ChoiceId { get; set; } = Guid.NewGuid();

        [JsonPropertyName("choiceTitle")]
        [Required(ErrorMessage = "Alternativet kan inte vara tomt")]
        public string ChoiceTitle { get; set; } = "";

        [JsonPropertyName("choiceOrder")]
        public int ChoiceOrder { get; set; }

        [JsonPropertyName("choiceDate")]
        public DateTime ChoiceDate { get; set; }

        [JsonPropertyName("questionId")]
        public Guid QuestionId { get; set; }
    }
}
