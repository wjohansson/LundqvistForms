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

        [JsonPropertyName("multipleChoiceOptions")]
        [ForeignKey("QuestionId")]
        public ICollection<MultipleChoiceOptions> MultipleChoiceOptions { get; set; }

        [JsonPropertyName("singleChoiceOptions")]
        [ForeignKey("QuestionId")]
        public ICollection<SingleChoiceOptions> SingleChoiceOptions { get; set; }

        [JsonPropertyName("dropwdownChoiceOptions")]
        [ForeignKey("QuestionId")]
        public ICollection<DropdownChoiceOptions> DropdownChoiceOptions { get; set; }

        [JsonPropertyName("scaleOptions")]
        public ScaleOptions ScaleOptions { get; set; }

        [JsonPropertyName("segmentId")]
        public Guid SegmentId { get; set; }

        [ForeignKey("QuestionId")]
        [JsonPropertyName("answers")]
        public ICollection<AnswerModel> Answers { get; set; }

        public QuestionModel()
        {
            Answers = new List<AnswerModel>();
            MultipleChoiceOptions = new List<MultipleChoiceOptions>();
            SingleChoiceOptions = new List<SingleChoiceOptions>();
            DropdownChoiceOptions = new List<DropdownChoiceOptions>();
            ScaleOptions = new ScaleOptions();
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
