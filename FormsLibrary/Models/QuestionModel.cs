using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FormsLibrary.Models
{
    public class QuestionModel
    {
        [Key]
        [JsonPropertyName("questionId")]
        public Guid QuestionId { get; set; } = Guid.NewGuid();

        [JsonPropertyName("questionTitle")]
        [Required(ErrorMessage = "Frågan måste ha en rubrik")]
        public string QuestionTitle { get; set; } = "";

        [JsonPropertyName("quetsionOption")]
        [Required]
        public QuestionOptions QuestionOption { get; set; }

        [JsonPropertyName("sectionId")]
        public Guid SectionId { get; set; }

        [ForeignKey("QuestionId")]
        [JsonPropertyName("answers")]
        public ICollection<AnswerModel> Answers { get; set; }

        public QuestionModel()
        {
            Answers = new List<AnswerModel>();
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
