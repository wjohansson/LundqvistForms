using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FormsLibrary.Models
{
    public class AnswerModel
    {
        [Key]
        [JsonPropertyName("answerId")]
        public Guid AnswerId { get; set; } = Guid.NewGuid();

        [JsonPropertyName("answer")]
        public string? Answer { get; set; }

        [JsonPropertyName("answerDate")]
        public DateTime AnswerDate { get; set; } = DateTime.Now;

        [JsonPropertyName("questionId")]
        public Guid QuestionId { get; set; }
    }
}
