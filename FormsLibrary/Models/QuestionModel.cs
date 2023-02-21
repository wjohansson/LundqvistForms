using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FormsLibrary.Models
{
    public class QuestionModel
    {
        [Key]
        [JsonPropertyName("questionId")]
        public Guid QuestionId { get; set; } = Guid.NewGuid();

        [JsonPropertyName("questionTitle")]
        [Required(ErrorMessage = "Frågan kan inte vara tom")]
        public string QuestionTitle { get; set; } = "";

        [JsonPropertyName("quetsionOption")]
        [Required]
        public QuestionOptions QuestionOption { get; set; }

        [JsonPropertyName("choiceOptions")]
        [ForeignKey("QuestionId")]
        public ICollection<ChoiceModel> ChoiceOptions { get; set; }

        [JsonPropertyName("scaleOptions")]
        public ScaleModel ScaleOptions { get; set; }

        [JsonPropertyName("segmentId")]
        public Guid SegmentId { get; set; }

        [ForeignKey("QuestionId")]
        [JsonPropertyName("answers")]
        public ICollection<AnswerModel> Answers { get; set; }

        public QuestionModel()
        {
            Answers = new List<AnswerModel>();
            ChoiceOptions = new List<ChoiceModel>();
            ScaleOptions = new ScaleModel();
        }
    }

    public enum QuestionOptions
    {
        Flerval,
        Enkelval,
        Dropdown,
        Skala,
        Datum,
        Tidsintervall,
        Tid,
        Kort,
        Lång
    }
}
