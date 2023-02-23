using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FormsLibrary.Models
{
    public class FormModel
    {
        // TODO: Datum på skapas och ändras
        // TODO: Fixa edit funktion så att det gamla formuläret sparas som en "gammal version"
        [Key]
        [JsonPropertyName("formId")]
        public Guid FormId { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Formuläret måste ha en rubrik")]
        [JsonPropertyName("formTitle")]
        public string FormTitle { get; set; } = "";

        [Required(ErrorMessage = "Formuläret måste ha en beskrivning")]
        [JsonPropertyName("formDescription")]
        public string FormDescription { get; set; } = "";

        [JsonPropertyName("dateCreated")]
        public DateTime DateCreated { get; set; }

        [ForeignKey("FormId")]
        [JsonPropertyName("segments")]
        public ICollection<SegmentModel> Segments { get; set; }

        [ForeignKey("FormId")]
        [JsonPropertyName("answers")]
        public ICollection<AnswerModel> Answers { get; set; }

        public FormModel()
        {
            Segments = new List<SegmentModel>();
            Answers = new List<AnswerModel>();
        }
    }
}