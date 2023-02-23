using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FormsLibrary.Models
{
    public class AnswerModel
    {
        [Key]
        [JsonPropertyName("answerId")]
        public Guid AnswerId { get; set; } = Guid.NewGuid();

        [JsonPropertyName("shortAnswer")]
        public string? ShortAnswer { get; set; }

        [JsonPropertyName("longAnswer")]
        public string? LongAnswer { get; set; }

        [ForeignKey("AnswerId")]
        [JsonPropertyName("multipleChoice")]
        public ICollection<MultipleChoiceAnswerModel>? MultipleChoice { get; set; }

        [JsonPropertyName("singleCoice")]
        public string? SingleCoice { get; set; }

        [JsonPropertyName("dropdown")]
        public string? DropdownChoice { get; set; }

        [JsonPropertyName("scale")]
        public int Scale { get; set; }

        [JsonPropertyName("date")]
        public DateTime? Date { get; set; }

        [JsonPropertyName("interval")]
        public TimeIntervalAnswerModel Interval { get; set; }

        [JsonPropertyName("time")]
        public TimeSpan? Time { get; set; }

        [JsonPropertyName("answerDate")]
        public DateTime AnswerDate { get; set; }

        [JsonPropertyName("questionId")]
        public Guid QuestionId { get; set; }

        [JsonPropertyName("formId")]
        public Guid FormId { get; set; }

        public AnswerModel()
        {
            MultipleChoice = new List<MultipleChoiceAnswerModel>();
        }
    }
}
