using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FormsLibrary.Models
{
    public class FormModel
    {
        [Key]
        [JsonPropertyName("formId")]
        public Guid FormId { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Formuläret måste ha en rubrik")]
        [JsonPropertyName("formTitle")]
        public string FormTitle { get; set; } = "";

        [Required(ErrorMessage = "Formuläret måste ha en beskrivning")]
        [JsonPropertyName("formDescription")]
        public string FormDescription { get; set; } = "";

        [ForeignKey("FormId")]
        [JsonPropertyName("sections")]
        public ICollection<SectionModel> Sections { get; set; }

        public FormModel()
        {
            Sections = new List<SectionModel>();
        }
    }
}