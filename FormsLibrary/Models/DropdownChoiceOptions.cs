using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FormsLibrary.Models
{
    public class DropdownChoiceOptions
    {
        [Key]
        [JsonPropertyName("dropdownChoiceID")]
        public Guid DropdownChoiceId { get; set; } = Guid.NewGuid();

        [JsonPropertyName("dropwdownChoiceTitle")]
        [Required(ErrorMessage = "Alternativet kan inte vara tomt")]
        public string DropdownChoiceTitle { get; set; } = "";

        [JsonPropertyName("questionId")]
        public Guid QuestionId { get; set; }
    }
}
