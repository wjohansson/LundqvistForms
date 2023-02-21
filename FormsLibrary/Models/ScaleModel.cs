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
    public class ScaleModel
    {
        [Key]
        [JsonPropertyName("scaleID")]
        public Guid ScaleId { get; set; } = Guid.NewGuid();

        [JsonPropertyName("low")]
        [Required(ErrorMessage = "Låga alternativet kan inte vara tomt")]
        public int Low { get; set; } = 1;

        [JsonPropertyName("high")]
        [Required(ErrorMessage = "Höga alternativet kan inte vara tomt")]
        public int High { get; set; } = 5;

        [JsonPropertyName("lowLabel")]
        public string? LowLabel { get; set; }

        [JsonPropertyName("highLabel")]
        public string? HighLabel { get; set; }

        [JsonPropertyName("questionId")]
        public Guid QuestionId { get; set; }

        [JsonIgnore]
        [ForeignKey("QuestionId")]
        public QuestionModel Question { get; set; }
    }
}
